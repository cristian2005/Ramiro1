using Bunifu.Framework.UI;
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
    public partial class Inicio_Sesion : Form
    {
        public Inicio_Sesion()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Reutilizar.Validar_All_TextBoxt_Vacio(panelRight, txtpass))
            {
                dynamic data = CRUD.Get_data_row("Usuarios/usuarios.json", x => x.Usuario == txtuser.Text && x.Clave == txtpass.Text);
                if (data != null)
                {
                    if (data.Estado==false)
                    {
                    MessageBox.Show(data.Nombre+" no esta activado, activelo para iniciar sesion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Usuarios user = new Usuarios { Apellidos = data.Apellidos, Nombre = data.Nombre, Clave = data.Clave, Estado = data.Estado, Id_usuario = data.Id_usuario, Usuario = data.Usuario };
                        new Dashboard(user).Show();
                        this.Hide();
                    }
                }
                else
                    MessageBox.Show("Usuario o clave incorrecta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Llene todo los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                Button1_Click(null,null);
            }
        }
    }
}
