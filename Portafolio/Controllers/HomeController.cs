using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using System.Text;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos, IConfiguration configuration)
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
            this._configuration = configuration;
        }

        public IActionResult Index()
        {
            var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
            var model = new HomeIndexViewModel()
            {
                Proyecto = proyectos,

            };
            return View(model);
        }

        public IActionResult Proyectos()
        {
            var proyectos = repositorioProyectos.ObtenerProyectos();
            return View(proyectos);
        }

        public IActionResult Contacto()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contacto(ContacoViewModel contacoViewModel)
        {

            if (ModelState.IsValid)
            {

            }

            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias()
        {
            return View();
        }


    }
}
