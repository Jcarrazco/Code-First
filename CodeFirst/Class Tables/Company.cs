using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Class_Tables
{
    public class Company
    {
        [Key]
        public int Company_ID { get; set; }//Primary Key
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Start_Date { get; set; }

        public List<Employee> Employees { get; set; }//clases que dependen de esta
        public List<Client> Clients { get; set; }//clases que dependen de esta
    }
}
