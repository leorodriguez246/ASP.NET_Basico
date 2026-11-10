using GameVault.Data;
using GameVault.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameVault.Controllers
{
    public class JuegoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JuegoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //mandar el listado de videojuegos desde la base de datos
            var catalogo = await _context.Videojuegos.ToListAsync();

            return View(catalogo);
        }


        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(Videojuego nuevoJuego)
        {
            if (!ModelState.IsValid)
            {
                return View(nuevoJuego);
            }

            _context.Videojuegos.Add(nuevoJuego);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
            
        }

        [HttpGet]
        public async Task<IActionResult> Editar(int Id)
        {
            var juego = await _context.Videojuegos.FindAsync(Id);
            if (juego == null)
            {
                return NotFound();
            }
            return View(juego);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Editar(Videojuego nuevoJuego)
        {
            if (!ModelState.IsValid)
            {
                return View(nuevoJuego);

            }

            _context.Update(nuevoJuego);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        [HttpGet]
        public async Task<IActionResult> Eliminar(int Id)
        {
            var juego = await _context.Videojuegos.FindAsync(Id);
            if (juego == null)
            {
                return NotFound();
            }
            _context.Videojuegos.Remove(juego);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
