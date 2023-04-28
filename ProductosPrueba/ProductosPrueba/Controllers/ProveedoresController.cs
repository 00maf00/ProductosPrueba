using Microsoft.AspNetCore.Mvc;

namespace ProductosPrueba.Controllers
{
    public class ProveedoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
