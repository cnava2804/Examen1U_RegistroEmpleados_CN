using Examen1U_RegistroEmpleados_CN.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1U_RegistroEmpleados_CN.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        } 

        public DbSet<EmployeeRegistration> EmployeeRegistrations { get; set; }
    }
}
