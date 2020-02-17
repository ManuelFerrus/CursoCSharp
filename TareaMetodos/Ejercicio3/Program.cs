using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main ( string[] args )
        {
            /*Elaborar una función , que permita recibir como parámetro un sueldo y una categoría , en el caso que la 
             * categoría sea A , se realiza un aumento               de 400 .
             * Si es B se realiza un aumento de 200 soles , 
             * si es C se realiza un aumento de 100 soles,
             * y si es una categoría distinta a las mencionadas se realiza un aumento de 50 soles
    */
            mostrarMensaje ( "Favor de ingresar el sueldo" );
            int sueldo=int.Parse ( pedirDato () );
            mostrarMensaje ( "Ingrese la categoria" );
            string categoria=pedirDato ();
            int sueldoFinal=calcularSueldo ( sueldo, categoria );
            mostrarMensaje ( "Sueldo final" );
            mostrarMensaje ( sueldoFinal.ToString () );
            noCerrarVentana ();
        }

        static void noCerrarVentana ( )
        {
            Console.ReadLine ();
        }

        static int calcularSueldo ( int sueldo, string categoria )
        {
            int sueldoFinal=0;
            switch ( categoria )
            {
                case "A":
                    sueldoFinal = hacerSuma ( sueldo, 400 );
                    break;
                case "B":
                    sueldoFinal = hacerSuma ( sueldo, 200 );
                    break;
                case "C":
                    sueldoFinal = hacerSuma ( sueldo, 100 );
                    break;
                default:
                    sueldoFinal = hacerSuma(sueldo, 50);
                    break;
            }
            return sueldoFinal;
        }

        static int hacerSuma ( int sueldo, int aumento )
        {
            return sueldo + aumento;
        }

        static void mostrarMensaje ( string cadena )
        {
            Console.WriteLine ( cadena );
        }

        static string pedirDato ( )
        {
            string dato=Console.ReadLine ().ToUpper();
            return dato;
        }

    }
}
