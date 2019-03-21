using CodeFirst.Class_Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Metodos_de_BD
{
    class OperacionesDBEmployee
    {
        //Se instancio el contexto de la BD y  se usa como entities
        private Hitss_TM_Context entities = new Hitss_TM_Context();
        //-------------------Create Query------------------------------------
        public void CreateEmployee(Employee NewEmployee, int ID_Company)
        {
            //Carga el objeto compañia que corresponde con el ID
            var Compania = entities.companies.FirstOrDefault(c => c.Company_ID == ID_Company);
            //se realiza la relacion agregando al nuevo employee a la lista de employees de compania
            Compania.Employees.Add(NewEmployee);
            entities.SaveChanges();
        }
        //-------------------Read queries------------------------------------
        public List<Employee> GetEmployees()//lista todos
        {
            return entities.employees.ToList();
        }
    }
}
