using AirTrafficControllerWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AirTrafficControllerWeb.Controllers.Planificacion
{
    public class PlanificacionController : Controller
    {
        private readonly ILogger<PlanificacionController> _logger;

        public PlanificacionController(ILogger<PlanificacionController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Planificacion2()
        {
            return View();
        }

        public IActionResult Planificacion3()
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
