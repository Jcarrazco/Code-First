using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Class_Tables
{
    class Hitss_TM_Context : DbContext 
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Employee_Project> employee_Projects { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Cat_Role> cat_Roles { get; set; }
    }
}
