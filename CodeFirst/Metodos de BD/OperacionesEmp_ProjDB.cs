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
        public void CreateEmployee_Project(int Project_ID, int Employee_ID, int Role_ID)
        {
            Employee_Project EP = new Employee_Project();
            EP.Estado = 1;

            var project = entities.projects.FirstOrDefault(c => c.Project_ID == Project_ID);
            var Employe = entities.employees.FirstOrDefault(c => c.Employee_ID == Employee_ID);
            var Role = entities.cat_Roles.FirstOrDefault(c => c.Cat_Role_ID == Role_ID);

            project.Employee_Projects.Add(EP);
            Employe.employee_Projects.Add(EP);
            Role.Employee_Projects.Add(EP);

            entities.SaveChanges();
        }
        //-------------------Read queries------------------------------------
        public List<Employee_Project> GetEmployee_Projects()//lista todos
        {
            return entities.employee_Projects.ToList();
        }
    }
}
