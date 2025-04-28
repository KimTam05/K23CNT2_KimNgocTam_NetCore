using Microsoft.AspNetCore.Mvc;

namespace KntLesson02.Controllers
{
    public class KntProductController : Controller
    {
        public IActionResult KntProduct()
        {
            ViewData["messageData"] = "Data From ViewData";
            ViewBag.messageBag = "Data From ViewBag";
            TempData["messageTempData"] = "Data From TempData";
            return View();
        }
    }
}
