using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionClaseMatch
{
    class Program
    {
        static void Main ( string[] args )
        {
            double precio=20.6;
            int a = 2;
            int b=5;
            int c=37;
            int d=-2;
            //solo toma el numero entero, ignorando el punto decimal
            Console.WriteLine ( "Match.floor: " + Math.Floor ( precio ));
            //agarra la parte entera +1 //NO ES REDONDEO
            Console.WriteLine ( "Math.Ceiling: " + Math.Ceiling ( precio ) );
            //Redondeo
            Console.WriteLine ( "Math.Round: " + Math.Round ( precio ) );
            //Elevar un numero a una potencia
            Console.WriteLine ( "Potencia: " + Math.Pow ( a, b ) );
            //Raiz cuadrada
            Console.WriteLine ( "Raiz: " + Math.Sqrt ( c ) );
            //Numero mas grande de dos numeros
            Console.WriteLine ( "El mayor es: " + Math.Max ( b, c ) );
            //Numero menor de dos numeros
            Console.WriteLine ( "El menor es: " + Math.Min ( a, b ) );
            //Valor absoluto
            Console.WriteLine ( "El valor absoluto es: " + Math.Abs ( d ) );
            Console.ReadLine ();
            
        }
    }
}
