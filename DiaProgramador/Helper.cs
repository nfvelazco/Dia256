using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaProgramador
{
    public static class Personal
    {
        public const string Secretaria = "Secretaria"; 
        public const string GDP = "GDP"; 
        public const string Mujer = "Mujer";
        public const string Programador = "Programador"; 

    }

    public class DiasFestivos {
        static new Dictionary<DateTime, string> geter = new Dictionary<DateTime, string>();

        public static Dictionary<DateTime, string> Get {
            get {
                geter.Add(new DateTime(2018, 00, 00), Personal.Secretaria);
                geter.Add(new DateTime(2018, 00, 00), Personal.Mujer);
                geter.Add(new DateTime(2018, 00, 00), Personal.GDP);
                geter.Add(new DateTime(2018, 00, 00), Personal.Programador);
                return geter;
            }
        }
                
    }
}
