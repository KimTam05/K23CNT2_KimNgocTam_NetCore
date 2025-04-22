using System.Diagnostics;
using KntLesson01MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace KntLesson01MVC.Controllers
{
    public class KntHomeController : Controller
    {
        private readonly ILogger<KntHomeController> _logger;

        public KntHomeController(ILogger<KntHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult KntIndex()
        {
            return View();
        }

        public IActionResult KntAbout()
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
