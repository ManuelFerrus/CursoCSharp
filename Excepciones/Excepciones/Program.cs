using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Program
    {
        static void Main( string[] args )
        {
            //int numero1= 9, numero2=0;
            //try
            //{
            //    int resultado = numero1 / numero2;
            //}
            //catch ( DivideByZeroException )
            //{
            //    Console.WriteLine( "Ocurrio un error, no se puede divir entre cero" );
            //}
            ////int resultado1 = numero1 / numero2;
            //Console.WriteLine( "Hola" );

            //string numero ="123A";
            //try
            //{
            //    int numeroConvertido=int.Parse( numero );
            //    Console.WriteLine( "Numero Convertido " + numeroConvertido );
            //}
            //catch ( FormatException )
            //{
            //    Console.WriteLine( "Ocurrio un error, no se pudo convertir a entero" );
            //}
            //Console.WriteLine( "Hola" );
            //Console.WriteLine( "Hola" );
            //Console.WriteLine( "Hola" );
            //Console.WriteLine( "Hola" );
            //Console.WriteLine( "Hola" );

            int []numeros=new int[ 4 ];
            try
            {
                //numeros[ 0 ] = 10;
                //numeros[ 1 ] = 15;
                //numeros[ 2 ] = 18;
                //numeros[ 3 ] = 16;
                //numeros[ 4 ] = 5;
                string numerosCadena = "s123";
                int numeros1=int.Parse( numerosCadena );
            }
            //catch ( IndexOutOfRangeException )
            catch ( Exception ex )
            {
                Console.WriteLine( "Error: " + ex.Message );
            }
            finally //haya error o no, este bloque siempre se ejecuta
            {
                Console.WriteLine( "Hola como estas soy un Finally" );
            }
            Console.WriteLine( "Hola" );
            Console.ReadLine();
        }
    }
}
