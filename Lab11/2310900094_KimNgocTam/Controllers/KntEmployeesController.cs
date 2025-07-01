using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _2310900094_KimNgocTam.Models;

namespace _2310900094_KimNgocTam.Controllers
{
    public class KntEmployeesController : Controller
    {
        private readonly KimNgocTam2310900094Context _context;

        public KntEmployeesController(KimNgocTam2310900094Context context)
        {
            _context = context;
        }

        // GET: KntEmployees
        public async Task<IActionResult> KntIndex()
        {
            var employees = await _context.KntEmployees.ToListAsync();
            return View(employees);
        }

        // GET: KntEmployees/Details/5
        public async Task<IActionResult> KntDetails(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kntEmployee = await _context.KntEmployees
                .FirstOrDefaultAsync(m => m.KntEmpId == id);
            if (kntEmployee == null)
            {
                return NotFound();
            }

            return View(kntEmployee);
        }

        // GET: KntEmployees/Create
        public IActionResult KntCreate()
        {
            return View();
        }

        // POST: KntEmployees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KntCreate([Bind("KntEmpId,KntEmpName,KntEmpLevel,KntEmpStartDate,KntEmpStatus")] KntEmployee kntEmployee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kntEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(KntIndex));
            }
            return View(kntEmployee);
        }

        // GET: KntEmployees/Edit/5
        public async Task<IActionResult> KntEdit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kntEmployee = await _context.KntEmployees.FindAsync(id);
            if (kntEmployee == null)
            {
                return NotFound();
            }
            return View(kntEmployee);
        }

        // POST: KntEmployees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KntEdit(long id, [Bind("KntEmpId,KntEmpName,KntEmpLevel,KntEmpStartDate,KntEmpStatus")] KntEmployee kntEmployee)
        {
            if (id != kntEmployee.KntEmpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kntEmployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KntEmployeeExists(kntEmployee.KntEmpId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(KntIndex));
            }
            return View(kntEmployee);
        }

        // GET: KntEmployees/Delete/5
        public async Task<IActionResult> KntDelete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kntEmployee = await _context.KntEmployees
                .FirstOrDefaultAsync(m => m.KntEmpId == id);
            if (kntEmployee == null)
            {
                return NotFound();
            }

            return View(kntEmployee);
        }

        // POST: KntEmployees/Delete/5
        [HttpPost, ActionName("KntDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var kntEmployee = await _context.KntEmployees.FindAsync(id);
            if (kntEmployee != null)
            {
                _context.KntEmployees.Remove(kntEmployee);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(KntIndex));
        }

        private bool KntEmployeeExists(long id)
        {
            return _context.KntEmployees.Any(e => e.KntEmpId == id);
        }
    }
}
