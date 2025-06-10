using Lesson08.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson08.Controllers
{
    public class KntAccountController : Controller
    {
        private static List<KntAccount> accounts = new List<KntAccount>
        {
            new KntAccount
            {
                KntId = 1,
                KntFullName = "Kim Ngọc Tâm",
                KntPhone = "0987422491",
                KntEmail = "kimngoctam15@gmail.com",
                KntGender = "Nam",
                KntFacebook = "https://www.facebook.com/esperanza.prog/",
                KntAddress = "Hà Nội",
                KntAvatar = "avatar1.jpg",
                KntBirthday = new DateTime(1999, 1, 1),
                KntPassword = "123456"
            },
            new KntAccount
            {
                KntId = 2,
                KntFullName = "Nguyễn Văn B",
                KntPhone = "0912345678",
                KntEmail = "nguyenvanb@example.com",
                KntGender = "Nam",
                KntFacebook = "https://facebook.com/nguyenvanb",
                KntAddress = "TP.HCM",
                KntAvatar = "avatar2.jpg",
                KntBirthday = new DateTime(2000, 5, 10),
                KntPassword = "abc123"
            },
            new KntAccount
            {
                KntId = 3,
                KntFullName = "Trần Thị C",
                KntPhone = "0901234567",
                KntEmail = "tranthic@example.com",
                KntGender = "Nữ",
                KntFacebook = "https://facebook.com/tranthic",
                KntAddress = "Đà Nẵng",
                KntAvatar = "avatar3.jpg",
                KntBirthday = new DateTime(1998, 12, 20),
                KntPassword = "pass123"
            }
        };

        // GET: KntAccountController
        public ActionResult KntIndex()
        {
            return View(accounts);
        }

        // GET: KntAccountController/Details/5
        public ActionResult KntDetails(int id)
        {
            var account = accounts[id];
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: KntAccountController/Create
        public ActionResult KntCreate()
        {
            return View();
        }

        // POST: KntAccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult KntCreate(IFormCollection collection)
        {
            try
            {
                var newAccount = new KntAccount
                {
                    KntId = accounts.Count + 1,
                    KntFullName = collection["KntFullName"],
                    KntEmail = collection["KntEmail"],
                    KntPhone = collection["KntPhone"],
                    KntAddress = collection["KntAddress"],
                    KntAvatar = collection["KntAvatar"],
                    KntBirthday = DateTime.Parse(collection["KntBirthday"]),
                    KntGender = collection["KntGender"],
                    KntPassword = collection["KntPassword"]
                };
                accounts.Add(newAccount);
                return RedirectToAction(nameof(KntIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: KntAccountController/Edit/5
        public ActionResult KntEdit(int id)
        {
            var account = accounts.FirstOrDefault(a => a.KntId == id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }

        // POST: KntAccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult KntEdit(int id, IFormCollection collection)
        {
            try
            {
                var account = accounts.FirstOrDefault(a => a.KntId == id);
                if (account == null)
                {
                    return NotFound();
                }
                account.KntFullName = collection["KntFullName"];
                account.KntEmail = collection["KntEmail"];
                account.KntPhone = collection["KntPhone"];
                account.KntAddress = collection["KntAddress"];
                account.KntAvatar = collection["KntAvatar"];
                account.KntBirthday = DateTime.Parse(collection["KntBirthday"]);
                account.KntGender = collection["KntGender"];
                account.KntPassword = collection["KntPassword"];
                return RedirectToAction(nameof(KntIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: KntAccountController/Delete/5
        public ActionResult KntDelete(int id)
        {
            var account = accounts.FirstOrDefault(a => a.KntId == id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }

        // POST: KntAccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult KntDelete(int id, IFormCollection collection)
        {
            try
            {
                var account = accounts.FirstOrDefault(a => a.KntId == id);
                if (account == null)
                {
                    return NotFound();
                }
                accounts.Remove(account);
                return RedirectToAction(nameof(KntIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}
