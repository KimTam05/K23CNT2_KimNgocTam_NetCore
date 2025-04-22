using Microsoft.AspNetCore.Mvc;

namespace KntLesson01MVC.Controllers
{
    public class KntItemController : Controller
    {
        public IActionResult KntItem()
        {
            return View();
        }
    }
}
