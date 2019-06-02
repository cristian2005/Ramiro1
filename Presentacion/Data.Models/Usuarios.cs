using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Usuarios
    {
        public static  readonly string ruta = "Usuarios/Usuarios.json";
        public int Id_usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public bool Estado { get; set; }
        public static List<Usuarios> _Usuarios { get { return Reutilizar.Stack<Usuarios>(ruta); } }
        public static int Get_Max_Id()
        {
           return Reutilizar.Stack<Usuarios>(ruta).Max(x => x.Id_usuario)+1;
        }

    }
}
