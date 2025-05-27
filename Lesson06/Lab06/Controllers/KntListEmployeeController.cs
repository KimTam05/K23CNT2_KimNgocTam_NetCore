using Microsoft.AspNetCore.Mvc;
using Lab06.Models;

namespace Lab06.Controllers
{
    public class KntListEmployeeController : Controller
    {
        private static List<KntEmployee> kntEmployees = new List<KntEmployee>
        {
            new KntEmployee { KntId = 1, KntName = "Kim Ngọc Tâm", KntPhone = "0987422491", KntBirthday = new DateTime(2005, 1, 1), KntEmail = "kimngoctam15@gmail.com", KntSalary = 0m, KntIsActive = true },
            new KntEmployee { KntId = 2, KntName = "Tran Thi B", KntBirthday = new DateTime(1992, 8, 20), KntEmail = "thib@example.com", KntPhone = "0911222333", KntSalary = 12000000m, KntIsActive = false },
            new KntEmployee { KntId = 3, KntName = "Le Van C", KntBirthday = new DateTime(1988, 1, 5), KntEmail = "vanc@example.com", KntPhone = "0988777666", KntSalary = 18000000m, KntIsActive = true },
            new KntEmployee { KntId = 4, KntName = "Pham Thi D", KntBirthday = new DateTime(1995, 3, 30), KntEmail = "thid@example.com", KntPhone = "0933444555", KntSalary = 13500000m, KntIsActive = true },
            new KntEmployee { KntId = 5, KntName = "Hoang Van E", KntBirthday = new DateTime(1993, 11, 15), KntEmail = "minhe@example.com", KntPhone = "0977555444", KntSalary = 11000000m, KntIsActive = false }
        };

        public IActionResult KntIndex()
        {
            ViewBag.KntList = kntEmployees;
            return View();
        }
        public IActionResult KntCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult KntCreate(KntEmployee kntEmployee)
        {
            if (ModelState.IsValid)
            {
                kntEmployee.KntId = kntEmployees.Count > 0 ? kntEmployees.Max(e => e.KntId) + 1 : 1;
                kntEmployees.Add(kntEmployee);
                return RedirectToAction("KntIndex");
            }
            return View(kntEmployee);
        }
        [HttpGet]
        public IActionResult KntEdit(int id)
        {
            var kntEmployee = kntEmployees.FirstOrDefault(e => e.KntId == id);
            if (kntEmployee == null)
            {
                return NotFound();
            }
            return View(kntEmployee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult KntEdit(KntEmployee KntEditedValue)
        {
            if (ModelState.IsValid)
            {
                var KntisExisting = kntEmployees.FirstOrDefault(e => e.KntId == KntEditedValue.KntId);
                if (KntisExisting == null)
                    return NotFound();

                KntisExisting.KntName = KntEditedValue.KntName;
                KntisExisting.KntBirthday = KntEditedValue.KntBirthday;
                KntisExisting.KntEmail = KntEditedValue.KntEmail;
                KntisExisting.KntPhone = KntEditedValue.KntPhone;
                KntisExisting.KntSalary = KntEditedValue.KntSalary;
                KntisExisting.KntIsActive = KntEditedValue.KntIsActive;

                return RedirectToAction("KntIndex");
            }

            return View(KntEditedValue);
        }
        public IActionResult KntDelete(int id)
        {
            var kntEmployee = kntEmployees.FirstOrDefault(e => e.KntId == id);
            if (kntEmployee == null)
            {
                return NotFound();
            }
            return View(kntEmployee);
        }

        [HttpPost, ActionName("KntDelete")]
        [ValidateAntiForgeryToken]
        public IActionResult KntDeleteConfirmed(int id)
        {
            var KntEmployee = kntEmployees.FirstOrDefault(e => e.KntId == id);
            if (KntEmployee != null)
            {
                kntEmployees.Remove(KntEmployee);
            }

            return RedirectToAction("KntIndex");
        }

    }
}
