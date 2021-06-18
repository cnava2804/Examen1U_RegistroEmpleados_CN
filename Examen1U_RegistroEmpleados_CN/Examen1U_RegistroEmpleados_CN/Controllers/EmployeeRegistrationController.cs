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

        public async Task<IActionResult> Index()
        {
            return View(await db.EmployeeRegistrations.ToListAsync());
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


    }
}
