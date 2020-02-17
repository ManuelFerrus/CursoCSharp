using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main ( string[] args )
        {
            //.Elaborar un método que me permita ingresar dos números e imprimir los números pares que hay entre esos 2 valores.
            mostrarMensaje ( "Ingrese el primer número:" );
            int inicio=pedirNumero ();
            mostrarMensaje ( "Ingrese el segundo número:" );
            int final=pedirNumero ();
            mostrarMensaje ( "Los pares son:" );
            imprimirPares ( inicio, final );
            noCerrarVentana ();
        }

        static int pedirNumero ( )
        {
            int numero= int.Parse ( Console.ReadLine () );
            return numero;
        }

        static void imprimirPares ( int inicio, int final )
        {
            for ( int i = inicio; i <= final; i++ )
            {
                if ( i%2==0 )
                {
                    mostrarMensaje ( i.ToString () );
                }
            }
        }

        static void mostrarMensaje ( string cadena )
        {
            Console.WriteLine ( cadena );
        }

        static void noCerrarVentana ( )
        {
            Console.ReadLine ();
        }
    }
}
