using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductosPrueba.Data;
using ProductosPrueba.Modelos;

namespace ProductosPrueba.Controllers
{
    public class ZonasController : Controller
    {
        private readonly DataContext _context;

        public ZonasController(DataContext dataContext)
        {
            _context = dataContext;
        }

        //GET
        public IActionResult Index()
        {
            var zonas = _context.Zonas.ToList(); //listar
            return View(zonas); // regresar en la vista el listado
        }

        //GET 
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        public async Task<IActionResult> Create(Zona model)
        {
            await _context.AddAsync(model); //(Insert into Zonas values 'Prueba 123'
            await _context.SaveChangesAsync(); //Commit a la base de datos 
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var zona = await _context.Zonas.FindAsync(id);
            return View(zona);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Zona model)
        {
            var modelOld = await _context.Zonas.FindAsync(model.Id);
            modelOld.NombreZona = model.NombreZona;
            _context.Update(modelOld);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            var zona = await _context.Zonas.FindAsync(id);
            _context.Remove(zona);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
