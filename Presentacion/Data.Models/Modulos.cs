using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
   public class Modulos
    {
        public static readonly string ruta = "Administracion/Modulo.json";
        public int Id_modulo { get; set; }
        public string Modulo { get; set; }
        public static List<Modulos> _Modulo { get { return Reutilizar.Stack<Modulos>(ruta); }  }

    }
}
