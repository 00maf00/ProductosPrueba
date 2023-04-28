using Microsoft.AspNetCore.Mvc;
using ProductosPrueba.Data;

namespace ProductosPrueba.Controllers
{
    public class ProveedoresController : Controller
    {
        private readonly DataContext _context;

        public ProveedoresController(DataContext dataContext)
        {
            _context = dataContext;
        }

        //GET
        public IActionResult Index()
        {
            var proveedores = _context.Proveedores.ToList(); //listar
            return View(proveedores); // regresar en la vista el listado
        }

        //GET 
        public IActionResult Create()
        {
            return View();
        }
    }
}
