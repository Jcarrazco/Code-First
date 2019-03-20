using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Class_Tables
{
    public class Employee_Project
    {
        [Key]
        public int Employee_Project_ID { get; set; }
        public int Estado { get; set; }

        //public int Project_ID { get; set; }
        //public int Employee_ID { get; set; }
        //public int Cat_Role_ID { get; set; }
        public virtual Project project { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Cat_Role Cat_Role { get; set; }
    }
}
