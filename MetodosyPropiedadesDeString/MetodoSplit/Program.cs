using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoSplit
{
    class Program
    {
        static void Main ( string[] args )
        {
            //string palabra="CartucheraDba";
            //string[]array=palabra.Split ( 'r' );//split devuelve array de string
            ////split separa con un delimitador
            //foreach ( string item in array )
            //{
            //    Console.WriteLine ( item );
            //}

            string palabra="Hola amigos como estan";
            string[]array=palabra.Split ( ' ' );//split devuelve array de string
            //split separa con un delimitador
            foreach ( string item in array )
            {
                Console.WriteLine ( item );
            }
            Console.WriteLine ( "Numero de palabras " + array.Length );
            Console.ReadLine ();
        }
    }
}
