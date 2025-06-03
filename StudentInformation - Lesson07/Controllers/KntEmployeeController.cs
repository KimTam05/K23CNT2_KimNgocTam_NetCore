using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeInformation___Lesson07.Models; // Adjust the namespace according to your project structure


namespace EmployeeInformation___Lesson07.Controllers
{
    public class KntEmployeeController : Controller
    {
        // Data source:
        private static readonly List<KntEmployee> Employees = new List<KntEmployee>
        {
            new KntEmployee { KntId = 1, KntName = "Alice Johnson", KntBirthday = new DateTime(1990, 5, 12), KntEmail = "alice.johnson@example.com", KntPhone = "123-456-7890", KntSalary = 70000, KntIsActive = true },
            new KntEmployee { KntId = 2, KntName = "Bob Smith", KntBirthday = new DateTime(1985, 8, 23), KntEmail = "bob.smith@example.com", KntPhone = "234-567-8901", KntSalary = 85000, KntIsActive = true },
            new KntEmployee { KntId = 3, KntName = "Carol Lee", KntBirthday = new DateTime(1992, 3, 15), KntEmail = "carol.lee@example.com", KntPhone = "345-678-9012", KntSalary = 60000, KntIsActive = true },
            new KntEmployee { KntId = 4, KntName = "David Kim", KntBirthday = new DateTime(1988, 11, 30), KntEmail = "david.kim@example.com", KntPhone = "456-789-0123", KntSalary = 55000, KntIsActive = true },
            new KntEmployee { KntId = 5, KntName = "Eva Brown", KntBirthday = new DateTime(1995, 7, 8), KntEmail = "eva.brown@example.com", KntPhone = "567-890-1234", KntSalary = 75000, KntIsActive = true }
        };

        // GET: KntEmployeeController
        public ActionResult KntIndex()
        {
            return View(Employees);
        }

        // GET: KntEmployeeController/Details/5
        public ActionResult KntDetails(int id)
        {
            // Find the employee by ID
            var employee = Employees.FirstOrDefault(e => e.KntId == id);
            if (employee == null)
            {
                return NotFound(); // Return 404 if employee not found
            }
            return View(employee);
        }

        // GET: KntEmployeeController/Create
        public ActionResult KntCreate()
        {
            var newEmployee = new KntEmployee();
            
            return View(newEmployee);
        }

        // POST: KntEmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult KntCreate(KntEmployee newEmployee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Assign a new ID to the employee
                    newEmployee.KntId = Employees.Count > 0 ? Employees.Max(e => e.KntId) + 1 : 1;
                    
                    // Add the new employee to the list
                    Employees.Add(newEmployee);
                    
                    // Redirect to the index view
                    return RedirectToAction(nameof(KntIndex));
                }
                return RedirectToAction(nameof(KntIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: KntEmployeeController/Edit/5
        public ActionResult KntEdit(int id)
        {
            // Find the employee by ID
            var employee = Employees.FirstOrDefault(e => e.KntId == id);
            return View(employee);
        }

        // POST: KntEmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult KntEdit(int id, IFormCollection collection)
        {
            try
            {
                // Find the employee by ID
                var employee = Employees.FirstOrDefault(e => e.KntId == id);
                if (employee == null)
                    {
                    return NotFound();
                }
                // Edit variables from the form collection
                employee.KntName = collection["KntName"];
                employee.KntBirthday = DateTime.Parse(collection["KntBirthday"]);
                employee.KntEmail = collection["KntEmail"];
                employee.KntPhone = collection["KntPhone"];
                employee.KntSalary = decimal.Parse(collection["KntSalary"]);
                employee.KntIsActive = bool.Parse(collection["KntIsActive"]);
                // Save changes
                // In a real application, you would save changes to the database here
                return RedirectToAction(nameof(KntIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: KntEmployeeController/Delete/5
        public ActionResult KntDelete(int id)
        {
            // Find the employee by ID
            var employee = Employees.FirstOrDefault(e => e.KntId == id);
            if (employee == null)
            {
                return NotFound(); // Return 404 if employee not found
            }
            // Return the employee to the view for confirmation
            return View(employee);
        }

        // POST: KntEmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult KntDelete(int id, IFormCollection collection)
        {
            try
            {
                // Find the employee by ID
                var employee = Employees.FirstOrDefault(e => e.KntId == id);
                if(employee == null)
                {
                    return NotFound(); // Return 404 if employee not found
                }
                // Remove the employee from the list
                Employees.Remove(employee);
                return RedirectToAction(nameof(KntIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}
