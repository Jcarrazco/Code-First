using CodeFirst.Class_Tables;//permite el uso de las tablas del context escrito
using CodeFirst.Metodos_de_BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst
{
    public partial class CodeFirst : Form
    {
        public CodeFirst()
        {
            InitializeComponent();
        }

        

        private void CodeFirst_Load(object sender, EventArgs e)
        {

            Cbx_Search.Items.Add("Employee");
            Cbx_Search.Items.Add("Company");
            Cbx_Search.Items.Add("Client");
            Cbx_Search.Items.Add("Employee_Project");
            Cbx_Search.Items.Add("Project");
            Cbx_Search.Items.Add("Role");

        }

        private void Cbx_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = Cbx_Search.Text;
            Clear();
            if (selection == "Employee")
            {
                Lbl_campo1.Text = "First Name";
                Lbl_campo2.Text = "Last Name";
                Lbl_Campo3.Text = "Mail";
                Lbl_Campo4.Text = "Birth Date";
                Lbl_Campo5.Text = "Start Date";
                Lbl_Campo6.Text = "Company Id";
            }

            if (selection == "Company")
            {
                Lbl_campo1.Text = "Name";
                Lbl_campo2.Text = "Description";
                Lbl_Campo3.Text = "Start Date";
                Lbl_Campo4.Text = "";
                Lbl_Campo5.Text = "";
                Lbl_Campo6.Text = "";
            }

            if (selection == "Client")
            {
                Lbl_campo1.Text = "Name";
                Lbl_campo2.Text = "Description";
                Lbl_Campo3.Text = "Company ID";
                Lbl_Campo4.Text = "";
                Lbl_Campo5.Text = "";
                Lbl_Campo6.Text = "";
            }

            if(selection == "Project")
            {
                Lbl_campo1.Text = "Name";
                Lbl_campo2.Text = "Description";
                Lbl_Campo3.Text = "Client ID";
                Lbl_Campo4.Text = "";
                Lbl_Campo5.Text = "";
                Lbl_Campo6.Text = "";
            }

            if (selection == "Employee_Project")
            {
                Lbl_campo1.Text = "Project ID";
                Lbl_campo2.Text = "Employee ID";
                Lbl_Campo3.Text = "Role ID";
                Lbl_Campo4.Text = "";
                Lbl_Campo5.Text = "";
                Lbl_Campo6.Text = "";
            }

            if (selection == "Role")
            {
                Lbl_campo1.Text = "Name";
                Lbl_campo2.Text = "Description";
                Lbl_Campo3.Text = "";
                Lbl_Campo4.Text = "";
                Lbl_Campo5.Text = "";
                Lbl_Campo6.Text = "";
            }
        }

        private void Btn_crear_Click(object sender, EventArgs e)
        {
            string selection = Cbx_Search.Text;

            if (selection == "Employee")
            {
                //crea la instancia para los metodos
                OperacionesDBEmployee Ope = new OperacionesDBEmployee();
                //crea un nuevo objeto empleado y le carga datos
                Employee NewE = new Employee();
                NewE.First_Name = Txb_Datos1.Text;
                NewE.Last_Name = Txb_Datos2.Text;
                NewE.Mail = Txb_Datos3.Text;
                NewE.Birth_Date = Convert.ToDateTime(Txb_Datos4.Text);
                NewE.Start_Date = Convert.ToDateTime(Txb_Datos5.Text);
                NewE.Estado = 1;

                Ope.CreateEmployee(NewE, int.Parse(Txb_Datos6.Text));//manda a crear un empleado
            }
            if (selection == "Company")
            {
                //crea la instancia para los metodos
                var Ope = new OperacionesCompanyDB();
                //crea un nuevo objeto compañia y le carga datos
                Company NewC = new Company();
                NewC.Name = Txb_Datos1.Text;
                NewC.Description = Txb_Datos2.Text;
                NewC.Start_Date = Convert.ToDateTime(Txb_Datos3.Text);
                Ope.CreateCompany(NewC);//Crea nueva compañia
            }
            if (selection == "Client")
            {
                //crea la instancia para los metodos
                var Ope = new OperacionesClientDB();
                //Carga el Id de la compañia
                int Company_ID = Convert.ToInt32(Txb_Datos3.Text);
                //crea un nuevo objeto empleado y le carga datos
                Client NewC = new Client();
                NewC.Name = Txb_Datos1.Text;
                NewC.Description = Txb_Datos2.Text;
                NewC.Estado = 1;

                Ope.CreateClient(NewC,Company_ID);//manda a crear un cliente
            }
            if (selection == "Project")
            {
                var Ope = new OperacionesProjectsDB();
                int Client_Id = Convert.ToInt32(Txb_Datos3.Text);
                Project NewP = new Project();
                NewP.Name = Txb_Datos1.Text;
                NewP.Description = Txb_Datos2.Text;
                NewP.Estado = 1;

                Ope.CreateProject(NewP, Client_Id);
            }
            if (selection == "Employee_Project")
            {
                var Ope = new OperacionesEmp_ProjDB();
                int Project_ID = Convert.ToInt32(Txb_Datos1.Text);
                int Employee_ID = Convert.ToInt32(Txb_Datos2.Text);
                int Cat_Role_ID = Convert.ToInt32(Txb_Datos3.Text);

                Ope.CreateEmployee_Project(Project_ID,Employee_ID,Cat_Role_ID);
            }
            if (selection == "Role")
            {
                var DbHitss = new OperacionesCat_RoleBD();
                Cat_Role RoleN = new Cat_Role();
                RoleN.Name = Txb_Datos1.Text;
                RoleN.Description = Txb_Datos2.Text;
                RoleN.Estado = 1;

                DbHitss.CreateRole(RoleN);
            }

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Lstb_Results.Items.Clear();
            string selection = Cbx_Search.Text;
            if (selection == "Employee")
            {
                var DbHitss = new OperacionesDBEmployee();
                List<Employee> newE = DbHitss.GetEmployees();
                foreach (Employee c in newE)
                {
                    Lstb_Results.Items.Add(c.First_Name.ToString() + " " + c.Last_Name.ToString() +
                        " " + c.Mail.ToString() + " " + c.Birth_Date.ToString() + " " + 
                        c.Start_Date.ToString() + " " + c.Company.Company_ID.ToString());
                }

            }
            if (selection == "Company")
            {
                var DbHitss = new OperacionesCompanyDB();
                List<Company> companies = DbHitss.GetCompanies();
                foreach (Company c in companies)
                {
                    Lstb_Results.Items.Add(c.Name.ToString() + " " + c.Description.ToString()
                        + " " + c.Start_Date.ToString());
                }

            }
            if (selection == "Client")
            {
                var DbHitss = new OperacionesClientDB();
                List<Client> cliente = DbHitss.GetCLients();
                foreach (Client c in cliente)
                {
                    Lstb_Results.Items.Add(c.Name.ToString() + " " + c.Description.ToString()
                        + " " + c.Company.Company_ID.ToString());
                }

            }
            if (selection == "Project")
            {
                var DbHitss = new OperacionesProjectsDB();
                List<Project> Projectss = DbHitss.GetProjects();
                foreach (Project P in Projectss)
                {
                    Lstb_Results.Items.Add(P.Name.ToString() + " " + P.Description.ToString()
                        + " " + P.Client.Name.ToString());
                }

            }
            if (selection == "Employee_Project")
            {
                var DbHitss = new OperacionesEmp_ProjDB();
                List<Employee_Project> EmpProj = DbHitss.GetEmployee_Projects();
                foreach (Employee_Project c in EmpProj)
                {
                    Lstb_Results.Items.Add(c.project.Name.ToString() + " " + c.Employee.First_Name.ToString()
                        + " " + c.Cat_Role.Name.ToString());
                }

            }
            if (selection == "Role")
            {
                var DbHitss = new OperacionesCat_RoleBD();
                List<Cat_Role> Role = DbHitss.GetRoles();
                foreach (Cat_Role c in Role)
                {
                    Lstb_Results.Items.Add(c.Name.ToString() + " " + c.Description.ToString());
                }

            }
        }

        public void Clear()
        {
            Txb_Datos1.Text = "";
            Txb_Datos2.Text = "";
            Txb_Datos3.Text = "";
            Txb_Datos4.Text = "";
            Txb_Datos5.Text = "";
            Txb_Datos6.Text = "";
        }
    }
}
