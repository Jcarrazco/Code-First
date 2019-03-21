using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Class_Tables
{
    public class Client
    {
        [Key]
        public int Client_ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Estado { get; set; }

        //public int Company_ID { get; set; }//FK el nombre debe ser igual
        public virtual Company Company { get; set; }//Clase de la que depende es el ID
        public virtual List<Project> projects { get; set; }//Clase que depende de esta
    }
}
