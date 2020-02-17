using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndMetodo
{
    class Program
    {
        static void Main ( string[] args )
        {
            string apellido="Romam";
            if ( apellido.EndsWith("m" ))
            {
                Console.WriteLine ( "Termina con m" );
            }
            else
            {
                string ultimaletra=apellido.Substring ( apellido.Length - 1, 1 );
                Console.WriteLine ( "NO termina con m, termina con "+ultimaletra );
            }
            Console.ReadLine ();
        }
    }
}
