using CodeFirst.Class_Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Metodos_de_BD
{
    class OperacionesCompanyDB
    {
        //Se instancio el contexto de la BD y  se usa como entities
        private Hitss_TM_Context entities = new Hitss_TM_Context();
        //-------------------Create Query------------------------------------
        public void CreateCompany(Company NewCompany)
        {
            entities.companies.Add(NewCompany);
            entities.SaveChanges();
        }
        //-------------------Read queries------------------------------------
        public List<Company> GetCompanies()//lista todos
        {
            return entities.companies.ToList();
        }
    }
}
