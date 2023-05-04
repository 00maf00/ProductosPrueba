using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductosPrueba.Data;
using ProductosPrueba.Modelos;

namespace ProductosPrueba.Controllers
{
    public class ComprasController : Controller
    {
        //Conexion
        private readonly DataContext _context;

        public ComprasController(DataContext dataContext)
        {
            _context = dataContext;
        }

        //Listar
        public IActionResult Index()
        {
            var listado = _context.PR_COMPRAS_MMR.FromSqlRaw("exec PR_COMPRAS_MMR");
            return View(listado);
        }

        //Crear
        public async Task<IActionResult> Create()
        {          
            var Zonas = await _context.Zonas.ToListAsync();
            ViewData["IdZona"] = new SelectList(Zonas, "Id", "NombreZona");

            return View();
        }

    }
}
