using CodeFirst.Class_Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Metodos_de_BD
{
    class OperacionesClientDB
    {
        //Se instancio el contexto de la BD y  se usa como entities
        private Hitss_TM_Context entities = new Hitss_TM_Context();
        //-------------------Create Query------------------------------------
        public void CreateClient(Client NewClient, int ID_Comp)
        {
            var Compania = entities.companies.FirstOrDefault(c => c.Company_ID == ID_Comp);
            
            Compania.Clients.Add(NewClient);
            entities.SaveChanges();
        }
        //-------------------Read queries------------------------------------
        public List<Client> GetCLients()//lista todos
        {
            return entities.clients.ToList();
        }
    }
}
