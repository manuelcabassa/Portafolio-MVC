using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;

        public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos)
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
        }

        public IActionResult Index()
        {

            //ViewBag.Nombre = "Manuel Cabassa";

            //Persona persona = new Persona();
            //persona.Nombre = "Manuel Cabassa";
            //persona.Edad = 32;

            //var persona = new Persona() { Nombre = "Manuel Cabassa", Edad = 32 };
            //var repositorioProyectos = new RepositorioProyectos();
            var proyectos = repositorioProyectos.ObtenerProyectos().Take(4).ToList();
            var model = new HomeIndexViewModel()
            {
                Proyecto = proyectos
            };

            return View(model);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
