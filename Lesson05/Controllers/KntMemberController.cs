using Microsoft.AspNetCore.Mvc;
using Lesson05.Models.DataModel; // Ensure this namespace is correct based on your project structure

namespace Lesson05.Controllers
{
    public class KntMemberController : Controller
    {
        private List<KntMember> members;

        public IActionResult KntIndex()
        {
            return View();
        }
        public IActionResult KntGetMember()
        {
            var members = new List<KntMember>
            {
                new KntMember { KntMemberId = Guid.NewGuid().ToString(), KntUserName = "user1", KntFullName = "User One", KntPassword = "password1", KntEmail = "email01@gmail.com" },
                new KntMember { KntMemberId = Guid.NewGuid().ToString(), KntUserName = "user2", KntFullName = "User Two", KntPassword = "password2", KntEmail = "email02@gmail.com" },
                new KntMember { KntMemberId = Guid.NewGuid().ToString(), KntUserName = "user3", KntFullName = "User Three", KntPassword = "password3", KntEmail = "email.03@gmail.com" },
            };
            ViewBag.Members = members;
            return View();
        }
    }
}
