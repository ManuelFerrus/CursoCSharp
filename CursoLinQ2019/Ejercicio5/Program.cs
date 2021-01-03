using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Fuente de datos
            string[] nombres = { "Jorge", "Aldair", "Pedro", "Luis" };
            //2. Consulta
            var consulta = from nombre in nombres
                           where nombre.Contains("i")
                           orderby nombre descending
                           select nombre;
            //3. Ejecutamos consulta
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
