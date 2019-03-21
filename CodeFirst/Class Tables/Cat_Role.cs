using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Class_Tables
{
    public class Cat_Role
    {
        [Key]
        public int Cat_Role_ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Estado { get; set; }

        public virtual List<Employee_Project> Employee_Projects { get; set; }
    }
}
