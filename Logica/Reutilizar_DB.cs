using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
   public static class Reutilizar_DB
    {
        /// <summary>
        /// Metodo que pone o quita el color al panel izquierdo del panel del modulo
        /// </summary>
        /// <param name="panelmodulos"></param>
        /// <param name="btn"></param>
        public static void Ocultar_Poner_item_menu(Panel panelmodulos, Control btn)
        {
            foreach (Control item in panelmodulos.Controls)
            {

                // MessageBox.Show(item.Name.Substring(0, 1));
                if (item.Name.Substring(0, 2) == "pb")
                {
                    if (item.Name == "pb" + btn.Name)
                    {
                        item.BackColor = Color.White;
                    }
                    else
                        item.BackColor = Color.Transparent;
                }

            }
        }
    }
}
