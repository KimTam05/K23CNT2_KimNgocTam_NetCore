using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentInformation___Lesson07.Models;

namespace StudentInformation___Lesson07.Controllers
{
    public class KntHomeController : Controller
    {
        private readonly ILogger<KntHomeController> _logger;

        public KntHomeController(ILogger<KntHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Author()
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
