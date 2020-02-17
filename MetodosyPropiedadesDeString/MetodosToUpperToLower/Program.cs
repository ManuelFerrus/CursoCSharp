using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosToUpperToLower
{
    class Program
    {
        static void Main ( string[] args )
        {
            string utiles ="Me fui de Paseo";

            Console.WriteLine ( utiles.ToUpper () );
            Console.WriteLine ( utiles.ToLower () );

            string nombre1 ="Pablo";
            string nombre2 = "pablo";
            if ( nombre1.ToUpper().Equals(nombre2.ToUpper()) )
            {
                Console.WriteLine ( "Son iguales" );
            }
            else
            {
                Console.WriteLine ( "Son diferentes" );
            }
            Console.ReadLine ();

        }
    }
}
