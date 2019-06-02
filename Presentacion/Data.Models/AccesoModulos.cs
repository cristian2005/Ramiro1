using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class AccesoModulos
    {
        public static readonly string ruta = "Administracion/AccesoModulos.json";
        public int Id { get; set; }
        public int Id_modulo { get; set; }
        public int Id_usuario{ get; set; }
        public static List<AccesoModulos> _AccesoModulo { get { return Reutilizar.Stack<AccesoModulos>(ruta); }  }

       
    }
}
