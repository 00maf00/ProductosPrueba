using Microsoft.AspNetCore.Mvc;
using ProductosPrueba.Data;

namespace ProductosPrueba.Controllers
{
    public class CategoriasController : Controller
    {

        private readonly DataContext _context;

        public CategoriasController(DataContext dataContext)
        {
            _context = dataContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
