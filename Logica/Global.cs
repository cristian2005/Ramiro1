using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logica
{
    public static class GlobalS
    {
        public static  string URL_JSON = "../../../Data.Access/Json/";
        public  enum Modulos
        {
            DASHBOARD=1,
            CLIENTES,
            USUARIOS,
            CURSOS,
            ADMINISTRACION,
            REPORTES
        }
    }
}
