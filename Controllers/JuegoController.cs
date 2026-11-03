using GameVault.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameVault.Controllers
{
    public class JuegoController : Controller
    {
        private static List<Videojuego> _catalogo = new List<Videojuego>
        {
            new Videojuego (1,"Hollow Knight","Metroidvania","PC/SWITCH/XBOX/PS",25000,2017)
        };

        [HttpGet]
        public IActionResult Index()
        {
            //mandar el catalogo
            return View(_catalogo);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Videojuego nuevoJuego)
        {
            if (ModelState.IsValid)
            {
                nuevoJuego.Id = _catalogo.Count + 1;
                _catalogo.Add(nuevoJuego);
                return RedirectToAction(nameof(Index));
            }
            return View(nuevoJuego);
            
        }

        [HttpGet]
        public IActionResult Editar(int Id)
        {
            var juego = _catalogo.FirstOrDefault(c => c.Id == Id);
            if (juego == null)
            {
                return NotFound();
            }
            return View(juego);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Videojuego nuevoJuego)
        {
            if (!ModelState.IsValid)
            {
                return View(nuevoJuego);

            }

            var juegoExistente = _catalogo.FirstOrDefault(c => c.Id == nuevoJuego.Id);

            if (juegoExistente != null)
            {
                juegoExistente.Titulo = nuevoJuego.Titulo;
                juegoExistente.Genero = nuevoJuego.Genero;
                juegoExistente.Plataforma = nuevoJuego.Plataforma;
                juegoExistente.Precio = nuevoJuego.Precio;
                juegoExistente.Year = nuevoJuego.Year;

            }

            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Eliminar(int Id)
        {
            var juego = _catalogo.FirstOrDefault(c => c.Id == Id);
            if (juego != null)
            {
                _catalogo.Remove(juego);
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
