using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoContaint
{
    class Program
    {
        static void Main ( string[] args )
        {
            string mensaje="Me fui a comprar al cine";
            if ( mensaje.Contains("fue" ))
            {
                Console.WriteLine ( "Se encuentra" );
            }
            else
            {
                Console.WriteLine ( "No esta" );
            }
            Console.ReadLine ();
        }
    }
}
