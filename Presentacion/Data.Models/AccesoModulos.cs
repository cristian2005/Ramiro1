using Logica;
using System;
using Bunifu.Framework.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data.Models
{
    public class AccesoModulos
    {
        public static readonly string ruta = "Administracion/AccesoModulos.json";
        public int Id { get; set; }
        public int Id_modulo { get; set; }
        public int Id_usuario{ get; set; }
        public static List<AccesoModulos> _AccesoModulo { get { return Reutilizar.Stack<AccesoModulos>(ruta); }  }

        public static bool PermisosModulos(Control panel,int id_usuario)
        {
            try
            {
                foreach (var item in panel.Controls)
                {
                    if (item is BunifuCheckbox)
                    {
                        BunifuCheckbox check = item as BunifuCheckbox;
                        if (check.Checked == true)
                        {
                            CRUD.Insert_Data(new AccesoModulos { Id = Get_Max_Id(), Id_modulo = int.Parse(check.Name.Substring(2)), Id_usuario = id_usuario }, GlobalS.URL_JSON + "Administracion/AccesoModulos.json");
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public static int Get_Max_Id()
        {
            return Reutilizar.Stack<AccesoModulos>(ruta).Max(x => x.Id) + 1;
        }
    }
}
