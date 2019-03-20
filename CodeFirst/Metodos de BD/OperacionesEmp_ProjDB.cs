using CodeFirst.Class_Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Metodos_de_BD
{
    class OperacionesEmp_ProjDB
    {
        //Se instancio el contexto de la BD y  se usa como entities
        private Hitss_TM_Context entities = new Hitss_TM_Context();
        //-------------------Create Query------------------------------------
        public void CreateEmployee_Project(Employee_Project NewEmp_Proj)
        {
            entities.employee_Projects.Add(NewEmp_Proj);
            entities.SaveChanges();
        }
        //-------------------Read queries------------------------------------
        public List<Employee_Project> GetEmployee_Projects()//lista todos
        {
            return entities.employee_Projects.ToList();
        }
    }
}
