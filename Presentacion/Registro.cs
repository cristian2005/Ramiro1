using Data.Models;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ramiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var user = new Usuarios { Id_usuario = Usuarios.Get_Max_Id(), Apellidos = btxtapellido.Text, Clave = btncontra.Text, Estado = bunifuCheckbox1.Checked, Nombre = btxtnombre.Text, Usuario = btnusuario.Text };
         var result=  CRUD.Insert_Data(user, GlobalS.URL_JSON+ Usuarios.ruta);
            if (result)
            {
                new PermisosModulos(user.Id_usuario).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ocurrio un error al intentar crear este usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnusuario_Enter(object sender, EventArgs e)
        {
            btnusuario.Text = btxtnombre.Text.Substring(0, 1)+btxtapellido.Text;
        }
    }
}
