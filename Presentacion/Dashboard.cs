using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.Framework.UI;
using System.Windows.Forms;
using Logica;
using Data.Models;
using Newtonsoft.Json;
using Ramiro.UserControls;

namespace Ramiro
{
    public partial class Dashboard : Form
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
        private Usuarios user;

        public Dashboard(Usuarios user)
        {
            this.user = user;
            InitializeComponent();
        }
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 292)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                SidebarWrapper.Width = 300;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            

            //Poniendo el nombre al usuari
            lblnombre.Text = user.Nombre + " " + user.Apellidos + "-";
           
           

            Get_Modulo_User();
        }
        /// <summary>
        /// Agrega un control al panel derecho
        /// </summary>
        /// <param name="control">UserControl que se agregara al panel</param>
        private void AgregarUserControl(Control control)
        {
            control.Dock = DockStyle.Fill;
            Wrapper.Controls.Clear();
            Wrapper.Controls.Add(control);
        }
        /// <summary>
        /// Devuelve el icono por el parametro seleccionado
        /// </summary>
        /// <param name="icono_name"></param>
        /// <returns></returns>
        public Image Get_Icono_Modulo(string icono_name)
        {
            
            switch (icono_name)
            {
                case "ESTUDIANTES":
                    return Properties.Resources.USUARIOS;
                case "USUARIOS":
                    return Properties.Resources.ESTUDIANTES;
                case "CURSOS":
                    return Properties.Resources.CURSOS;
                case "ADMINISTRACION":
                    return Properties.Resources.ADMINISTRACION;
                case "DASHBOARD":
                    return Properties.Resources.DASHBOARD;
                case "REPORTES":
                    return Properties.Resources.REPORTES;
                default:
                    return Properties.Resources.logo;
                   
            }
        }
        /// <summary>
        /// Metodo que se ejecuta cuando le dan click a unos de los modulos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_modulos_click(object sender, EventArgs e)
        {
            BunifuFlatButton boton = sender as BunifuFlatButton;
            lblmodulo.Text = boton.Name;
            switch (boton.Name)
            {
                case "REPORTES":
                    boton_click_reportes(boton,e);
                    break;
                case "ESTUDIANTES":
                    boton_click_cliente(boton, e);
                    break;
                case "USUARIOS":
                    boton_click_usuarios(boton, e);
                    break;
                    
                case "CURSOS":
                    boton_click_cursos(boton, e);
                    break;

                case "ADMINISTRACION":
                    boton_click_administracion(boton, e);
                    break;
                case "DASHBOARD":
                    boton_click_dashboard(boton, e);
                    break;
            }
        }
        

        private void Get_Modulo_User()
        {
            var result = from accesomodulo in AccesoModulos._AccesoModulo
                         join usuario in Usuarios._Usuarios on accesomodulo.Id_usuario equals
                         usuario.Id_usuario join modulo in Modulos._Modulo on accesomodulo.Id_modulo equals
                         modulo.Id_modulo
                         where accesomodulo.Id_usuario == user.Id_usuario
                         select new { modulo.Modulo };
            if (result!=null)
            {
                foreach (var item in result)
                {
                    InicializarModulos(new BunifuFlatButton(), item.Modulo);
                }
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                new Inicio_Sesion().Show();
            }
        }



       ///Este apartado es para los click de cada modulo
       ///Click boton CLIENTES
       ///

        private void boton_click_cliente(BunifuFlatButton btn, EventArgs e)
        {
            //Mostrando lo del dashboard
            USC = new UserControlClientes();
            USC.Show();
            AgregarUserControl(USC);
            Reutilizar_DB.Ocultar_Poner_item_menu(panelmodulos, btn);
        }
        ///Click boton DASHBOARD
        ///
        UserControl USC;
        private void boton_click_dashboard(BunifuFlatButton btn, EventArgs e)
        {
            //Mostrando lo del dashboard
             USC = new UserControlDashboard();
            USC.Show();
            AgregarUserControl(USC);
            Reutilizar_DB.Ocultar_Poner_item_menu(panelmodulos, btn);
        }
        ///Click boton REPORTES
        ///

        private void boton_click_reportes(BunifuFlatButton btn, EventArgs e)
        {
            //Mostrando lo del REPORTES
            USC = new UserControlReportes();
            USC.Show();
            AgregarUserControl(USC);
            Reutilizar_DB.Ocultar_Poner_item_menu(panelmodulos, btn);

        }
        ///Click boton ADMINISTRACION
        ///

        private void boton_click_administracion(BunifuFlatButton btn, EventArgs e)
        {
            //Mostrando lo del Administracion
            USC = new UserControlAdministracion();
            USC.Show();
            AgregarUserControl(USC);
            Reutilizar_DB.Ocultar_Poner_item_menu(panelmodulos, btn);

        }
        ///Click boton USUARIOS
        ///

        private void boton_click_usuarios(BunifuFlatButton btn, EventArgs e)
        {
            //Mostrando lo del Usuarios
            USC = new UserControlUsuarios();
            USC.Show();
            AgregarUserControl(USC);
            Reutilizar_DB.Ocultar_Poner_item_menu(panelmodulos, btn);

        }
        ///Click boton CURSOS
        ///

        private void boton_click_cursos(BunifuFlatButton btn, EventArgs e)
        {
            //Mostrando lo del dashboard
            USC = new UserControlCursos();
            USC.Show();
            AgregarUserControl(USC);
            Reutilizar_DB.Ocultar_Poner_item_menu(panelmodulos, btn);

        }

        private void lblmodulo_Click(object sender, EventArgs e)
        {

        }
    }
}
