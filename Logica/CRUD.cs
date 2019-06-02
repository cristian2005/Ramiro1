using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Logica
{
    public static class CRUD
    {
       public static object Get_data_row(string modulo, Func<dynamic,bool> MODEL)
        {
            var data = Reutilizar.json(modulo).ToString();
            if (string.Empty != data)
            {
                 List < dynamic > obj  = (List<dynamic>)JsonConvert.DeserializeObject(data, typeof(List<dynamic>));
                return obj.Where(MODEL).FirstOrDefault();
            }
            return null;
        }
        public static object Get_data_rows(string modulo, Func<dynamic, bool> MODEL)
        {
            var data = Reutilizar.json(modulo).ToString();
            if (string.Empty != data)
            {
                List<dynamic> obj = (List<dynamic>)JsonConvert.DeserializeObject(data, typeof(List<dynamic>));
                return obj.Where(MODEL).ToList();
            }
            return null;
        }

        public static bool Insert_Data(dynamic data,string ruta)
        {
            var obj =  JsonConvert.SerializeObject(data) + ",";
            try
            {
                Stream stream = new FileStream(ruta, FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(stream);
                writer.WriteLine(obj);
                writer.Close();
                stream.Close();
                return true;
            }
            catch (Exception error)
            {
                return false;
            }
        }
            }
}
