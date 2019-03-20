using CodeFirst.Class_Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Metodos_de_BD
{
    class OperacionesCat_RoleBD
    {
        //Se instancio el contexto de la BD y  se usa como entities
        private Hitss_TM_Context entities = new Hitss_TM_Context();
        //-------------------Create Query------------------------------------
        public void CreateRole(Cat_Role NewRole)
        {
            entities.cat_Roles.Add(NewRole);
            entities.SaveChanges();
        }
        //-------------------Read queries------------------------------------
        public List<Cat_Role> GetRoles()//lista todos
        {
            return entities.cat_Roles.ToList();
        }
    }
}
