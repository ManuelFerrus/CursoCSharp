using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosNumeros
{
    class Program
    {
        static void Main ( string[] args )
        {
            //string numero ="15";
            ////Int16 -- short
            ////Int32 -- int
            ////Int64 -- long
            //int resultado;
            ////tryparse, es un metodo booleano, por lo tanto se cacha su resultado, para saber si se pudo convertir, TRUE si se pudo, FALSE no se convirtio
            //bool exito = Int32.TryParse ( numero, out resultado );
            //if ( exito )
            //{
            //    Console.WriteLine ( "Es un numero" );
            //}
            //else
            //{
            //    Console.WriteLine ( "No es un numero" );
            //}

            string numero = "15";
            int resultado;
            bool exito=Int32.TryParse ( numero, out resultado );
            int suma=resultado + 5;
            Console.WriteLine ( "La suma es: " + suma );

            Console.ReadLine ();
        }
    }
}
