using Microsoft.AspNetCore.Mvc;
using ProductosPrueba.Data;
using ProductosPrueba.Modelos;

namespace ProductosPrueba.Controllers
{
    public class ProductosController : Controller
    {
        private readonly DataContext _context;

        public ProductosController(DataContext dataContext)
        {
            _context = dataContext;
        }

        //GET
        public IActionResult Index()
        {
            var productos = _context.Productos.ToList(); //listar
            return View(productos); // regresar en la vista el listado
        }

        //GET 
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Productos model)
        {
            await _context.AddAsync(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            return View(producto);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Proveedor model)
        {
            var modelOld = await _context.Proveedores.FindAsync(model.Id);
            modelOld.NombreProveedor = model.NombreProveedor;
            modelOld.Ruc = model.Ruc;
            modelOld.Telefono = model.Telefono;
            modelOld.Direccion = model.Direccion;
            _context.Update(modelOld);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
