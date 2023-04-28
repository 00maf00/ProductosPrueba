using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductosPrueba.Data;
using ProductosPrueba.Modelos;

namespace ProductosPrueba.Controllers
{
    public class CategoriasController : Controller
    {

        private readonly DataContext _context;

        public CategoriasController(DataContext dataContext)
        {
            _context = dataContext;
        }

        //GET
        public async Task<IActionResult> Index(int id) 
        {
            var categorias = await _context.Categorias.Where(t => t.IdZona.Equals(id)).ToListAsync(); //dentro de la vista departamentos
            var modelZona = await _context.Zonas.FindAsync(id);
            ViewBag.Zona = modelZona;
            return View(categorias); 
        }

        public IActionResult Create(int idZona) //get IDzona 
        {
            var categoria = new Categoria { IdZona = idZona };
            return View(categoria);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Categoria model)
        {
            await _context.Categorias.AddAsync(model); //
            await _context.SaveChangesAsync(); 
            return RedirectToAction("Index", new { id = model.IdZona });
        }

        public async Task<IActionResult> Edit(int id) //abrir la pantalla
        {
            var categoria = await _context.Categorias.FindAsync(id); 
            return View(categoria); //retornar vista
        }

        [HttpPost] //hacer el cambio 
        public async Task<IActionResult> Edit(Categoria model)
        {
            var modelOld = await _context.Categorias.FindAsync(model.Id);
            modelOld.NombreCategoria = model.NombreCategoria;
            _context.Update(modelOld); 
            await _context.SaveChangesAsync(); 
            return RedirectToAction("Index", new { id = model.IdZona });
        }

        public async Task<IActionResult> Delete(int id)
        {
            var idZona = 0;
            var categoria = await _context.Categorias.FindAsync(id);
            if (categoria != null)
            {
                idZona = categoria.IdZona;
                _context.Remove(categoria);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index", new { id = idZona });

        }
    }
}
