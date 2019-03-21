using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Class_Tables
{
    public class Employee
    {
        [Key]
        public int Employee_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Mail { get; set; }
        public DateTime Birth_Date { get; set; }
        public DateTime Start_Date { get; set; }
        public int Estado { get; set; }

        //public int Company_ID { get; set; }
        public virtual Company Company { get; set; }
        public virtual List<Employee_Project> employee_Projects { get; set; }
    }
}
