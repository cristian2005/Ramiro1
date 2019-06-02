using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Ramiro.UserControls.CLIENTES;
namespace Ramiro.UserControls
{
    public partial class UserControlClientes : UserControl
    {
        public UserControlClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reutilizar.MostrarForm(new VistaClientes(), this.Parent);

        }
    }
}
