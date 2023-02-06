using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using wordeditor.Models;

namespace wordeditor.Controllers
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
            var model = new editorModel();
            model.des = "<p>HTML <ins>content </ins><em>default </em>in <strong>textarea</strong></p>";
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
        [HttpPost]
        public IActionResult SaveText(string area3)
        {
            return View();
        }
    }
}