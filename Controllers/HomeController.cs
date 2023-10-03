using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using tpeapp.Models;

namespace tpeapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DateTime dataHoraAtual = DateTime.Now;
            ViewBag.DataHoraAtual = dataHoraAtual;

            return View();
        }

        public IActionResult PointsCarouselView()
        {
            return View();
        }
    }
}