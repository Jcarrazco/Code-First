using CodeFirst.Class_Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Metodos_de_BD
{
    class OperacionesProjectsDB
    {
        //Se instancio el contexto de la BD y  se usa como entities
        private Hitss_TM_Context entities = new Hitss_TM_Context();
        //-------------------Create Query------------------------------------
        public void CreateProject(Project NewProject)
        {
            entities.projects.Add(NewProject);
            entities.SaveChanges();
        }
        //-------------------Read queries------------------------------------
        public List<Project> GetProjects()//lista todos
        {
            return entities.projects.ToList();
        }
    }
}
