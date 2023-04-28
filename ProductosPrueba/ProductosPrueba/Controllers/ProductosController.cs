using Microsoft.AspNetCore.Mvc;

namespace ProductosPrueba.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
