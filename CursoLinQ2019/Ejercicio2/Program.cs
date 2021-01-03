using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. fuente de datos
            int[] numeros = { 21, 56, 18, 100, 12 };
            //2. definir consulta
                                //variable de rango
            var consulta = from numero in numeros
                            where numero < 90
                            select numero;
            //3. Ejecutamos la consulta
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
