using Examen1U_RegistroEmpleados_CN.Data;
using Examen1U_RegistroEmpleados_CN.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen1U_RegistroEmpleados_CN.Controllers
{
    public class EmployeeRegistrationController : Controller
    {
        private readonly ApplicationDbContext db;

        public EmployeeRegistrationController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Index(string search)
        {
            if (search == null)
            {
                return View(await db.EmployeeRegistrations.ToListAsync());
            }

            return View(await db.EmployeeRegistrations
                .Where(s => s.EmpRegistrationNames.Contains(search)).ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var EmployeeRegis = await db.EmployeeRegistrations.FirstOrDefaultAsync(e => e.EmpRegistrationId == id);

            if (EmployeeRegis == null)
            {
                return NotFound();
            }

            return View(EmployeeRegis);


        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(EmployeeRegistration employeeRegistration)
        {
            if (ModelState.IsValid)
            {
                db.Add(employeeRegistration);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeeRegistration);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var depart = await db.EmployeeRegistrations.FindAsync(id);

            if (depart == null)
            {
                return NotFound();
            }

            return View(depart);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EmployeeRegistration EmployeeReg)
        {
            if (id != EmployeeReg.EmpRegistrationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(EmployeeReg);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }

            return View(EmployeeReg);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var EmployeeReg = await db.EmployeeRegistrations.FirstOrDefaultAsync(e => e.EmpRegistrationId == id);

            if (EmployeeReg == null)
            {
                return NotFound();
            }

            return View(EmployeeReg);

        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var EmployeeReg = await db.EmployeeRegistrations.FindAsync(id);
            db.EmployeeRegistrations.Remove(EmployeeReg);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
