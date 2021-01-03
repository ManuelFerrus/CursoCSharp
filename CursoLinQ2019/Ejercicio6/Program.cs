using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Fuente de datos
            int[] numeros = { 9, 11, 4, 7, 12, 16, 15 };
            //2 Definimos consulta
            var consulta = from numero in numeros
                           orderby numero descending
                           select numero;
            //3 Ejecutamos consulta
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
