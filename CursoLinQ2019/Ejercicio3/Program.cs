using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. fuente de datos
            int[] numeros = { 11, 15, 17, 19, 14, 18 };
            //2 definir consulta
            var consulta = from numero in numeros
                           where numero > 12 && numero < 17
                           select numero;
            //3 ejecutamos
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
