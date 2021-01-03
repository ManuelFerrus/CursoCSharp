using System;
using System.Linq;

namespace CursoLinQ2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 fuent de datos
            int[] numeros = { 99, 56, 75, 45, 12 };
            //2 definimos la consulta
            var consulta = from numero in numeros
                           where numero > 70
                           select numero;//consulta LinQ
            //3 Ejecucion de consulta
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
