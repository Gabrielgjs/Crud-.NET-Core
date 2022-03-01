using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuPrimeiroCrud.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<Employee> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
