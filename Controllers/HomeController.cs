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
            return View();
        }

        public IActionResult PontosView()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }
    }
}