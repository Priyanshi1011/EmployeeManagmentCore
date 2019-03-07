using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeManagmentUsingAsp.NetCoreWithEF.Models;

namespace EmployeeManagmentUsingAsp.NetCoreWithEF.Models
{
    public class EmployeeManagmentUsingAspNetCoreWithEFContext : DbContext
    {
        public EmployeeManagmentUsingAspNetCoreWithEFContext (DbContextOptions<EmployeeManagmentUsingAspNetCoreWithEFContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeManagmentUsingAsp.NetCoreWithEF.Models.Department> Department { get; set; }

        public DbSet<EmployeeManagmentUsingAsp.NetCoreWithEF.Models.Employee> Employee { get; set; }
    }
}
