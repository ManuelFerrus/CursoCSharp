using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main ( string[] args )
        {
            //Elaborar una función , que me permita ingresar un precio (tipo de dato decimal) y devolver cuanto se pagaría finalmente si se realizo un descuento del 20%
            mostrarMensaje ( "Ingrese el precio:" );
            decimal precio=pedirPrecio ();
            mostrarMensaje ( "Total a pagar (-20%):" );
            decimal resultado= calcularTotal ( precio );
            mostrarMensaje ( resultado.ToString () );
            noCerrarVentana ();
        }

        static decimal calcularTotal ( decimal precio )
        {
            decimal total=precio - ( precio * .20m );
            return total;
        }

        static decimal pedirPrecio ( )
        {
            decimal precioObtenido=decimal.Parse ( Console.ReadLine () );
            return precioObtenido;
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
