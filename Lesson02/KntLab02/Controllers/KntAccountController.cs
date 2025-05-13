using Microsoft.AspNetCore.Mvc;
using KntLab02.Models;

namespace KntLab02.Controllers
{
    public class KntAccountController : Controller
    {
        [Route("ho-so", Name = "index")]
        public IActionResult Index()
        {
            List<KntAccount> accounts = new List<KntAccount>
            {
                new KntAccount()
                {
                    KntId = 1,
                    KntName = "John Doe",
                    KntEmail = "johndoe033@gmail.com",
                    KntPhone = "1234567890",
                    KntAddress = "123 Main St, Cityville",
                    KntAvatar = Url.Content("~/images/Avatar/avatar_1.png"),
                    KntGender = 1,
                    KntBio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    KntBirthday = new DateTime(1990, 1, 1),
                }
                ,
                new KntAccount()
                {
                    KntId = 2,
                    KntName = "Jane Smith",
                    KntEmail = "janesmith099@gmail.com",
                    KntPhone = "0987654321",
                    KntAddress = "456 Elm St, Townsville",
                    KntAvatar = Url.Content("~/images/Avatar/avatar_2.png"),
                    KntGender = 2,
                    KntBio = "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    KntBirthday = new DateTime(1992, 2, 2),
                }
                ,
                new KntAccount()
                {
                    KntId = 3,
                    KntName = "Alice Johnson",
                    KntEmail = "alicejohnson055@gmail.com",
                    KntPhone = "1122334455",
                    KntAddress = "789 Oak St, Villagetown",
                    KntAvatar = Url.Content("~/images/Avatar/avatar_3.png"),
                    KntGender = 1,
                    KntBio = "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    KntBirthday = new DateTime(1995, 3, 3),
                }
            };
            ViewBag.accounts = accounts;
            return View();
        }
        [Route("ho-so-cua-toi", Name = "profile")]
        public IActionResult Profile(int id)
        {
            List<KntAccount> accounts = new List<KntAccount>
            {
                new KntAccount()
                {
                    KntId = 1,
                    KntName = "John Doe",
                    KntEmail = "johndoe033@gmail.com",
                    KntPhone = "1234567890",
                    KntAddress = "123 Main St, Cityville",
                    KntAvatar = Url.Content("~/images/Avatar/avatar_1.png"),
                    KntGender = 1,
                    KntBio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    KntBirthday = new DateTime(1990, 1, 1),
                },
                new KntAccount()
                {
                    KntId = 2,
                    KntName = "Jane Smith",
                    KntEmail = "janesmith099@gmail.com",
                    KntPhone = "0987654321",
                    KntAddress = "456 Elm St, Townsville",
                    KntAvatar = Url.Content("~/images/Avatar/avatar_2.png"),
                    KntGender = 2,
                    KntBio = "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    KntBirthday = new DateTime(1992, 2, 2),
                },
                new KntAccount()
                {
                    KntId = 3,
                    KntName = "Alice Johnson",
                    KntEmail = "alicejohnson055@gmail.com",
                    KntPhone = "1122334455",
                    KntAddress = "789 Oak St, Villagetown",
                    KntAvatar = Url.Content("~/images/Avatar/avatar_3.png"),
                    KntGender = 1,
                    KntBio = "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    KntBirthday = new DateTime(1995, 3, 3),
                }
            };
            // Find the account with the specified KntId
            KntAccount account = accounts.FirstOrDefault(ac => ac.KntId == id);
            ViewBag.account = account;
            return View();
        }
    }
}
