using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaProgramador
{
    class Program
    {
        public class Gift {

        }
        public class Issue {
            public bool Finished { get; set; }
        }
        public static class Secretarias {
            public static Gift Send(Gift Regalito) {
                return Regalito;
            }
        }
        public static class Mujeres
        {
            public static Gift Send(Gift Regalito)
            {
                return Regalito;
            }
        }
        public static class GDPs
        {
            public static Gift Send(Gift Regalito)
            {
                return Regalito;
            }
        }
        public static class Programadores {
            public static Issue Send(Issue Regalito) {
                return Regalito;
            }
        }
        

        static void Main(string[] args)
        {
            var diasFestivos = DiasFestivos.Get;
            foreach (var dia in diasFestivos)
            {
                string format = "Feliz día {0}, aqui va tu premio!";

                switch (dia.Value)
                {
                    case Personal.Secretaria:
                        Console.Write(string.Format(format, Personal.Secretaria));
                        Secretarias.Send(new Gift());
                        break;
                    case Personal.GDP:
                        Console.Write(string.Format(format, Personal.GDP));
                        GDPs.Send(new Gift());
                        break;
                    case Personal.Mujer:
                        Console.Write(string.Format(format, Personal.Mujer));
                        Mujeres.Send(new Gift());
                        break;
                    case Personal.Programador:
                        Console.Write(string.Format(format, Personal.Programador));
                        Programadores.Send(new Issue());
                        break;
                }
            }
        }
    }
}
