using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public static class Reutilizar
    {
        public static object json(string modulo)
        {
            try
            {
                Stream streams = new FileStream(GlobalS.URL_JSON + modulo, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(streams);
                var json = "[" + reader.ReadToEnd() + "]";
                reader.Close();
                streams.Close();
                return json;
            }
            catch (Exception error)
            {
                return MessageBox.Show(error.Message);
                // return MessageBox.Show("Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Devuelve false si hay un input vacio
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="tipo_Control"></param>
        /// <returns></returns>
        public static bool Validar_All_TextBoxt_Vacio(Control panel, Control tipo_Control)
        {
            foreach (Control item in panel.Controls)
            {
                if (tipo_Control.GetType() ==item.GetType())
                {
                    if (string.IsNullOrEmpty(item.Text))
                    {
                        return false;
                    }
                }
                
            }
            return true;
        }
        /// <summary>
        /// Obteniene un json de la ruta especificada y lo deserializa 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_rutamodulo"></param>
        /// <returns>Devuelve un listado de una clase especificada</returns>
        public static List<T> Stack<T>(string _rutamodulo)
        {
            var data = json(_rutamodulo).ToString();

            if (string.Empty != data)
            {
                    List<T> obj = (List<T>)JsonConvert.DeserializeObject(data, typeof(List<T>));
                return obj;
            }
            else
            return null;
        }
       public static string Eliminar_Columna_Data(string obj)
        {
            string cadena = "{";
            var values = obj.Replace("{","").Replace("}","").Split(',');
            foreach (var item in values)
            {
                if (item.IndexOf("Ruta") != -1)
                {

                }
                else
                    cadena += item;
            }
            return cadena="}";
        }
    }
}
