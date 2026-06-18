using Microsoft.AspNetCore.Mvc;
using T3_Apellido_Nombre.Datos;
using T3_Apellido_Nombre.Models;

namespace T3_Apellido_Nombre.Controllers
{
    public class LibroController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LibroController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Libro> lista = _db.Libro;
            return View(lista);
        }

    }
}
