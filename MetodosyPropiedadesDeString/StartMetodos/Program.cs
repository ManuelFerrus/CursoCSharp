using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartMetodos
{
    class Program
    {
        static void Main ( string[] args )
        {
            //string aves="Pollo";
            //if ( aves.StartsWith ( "P" ) )
            //{
            //    Console.WriteLine ( "ok" );
            //}
            //else
            //{
            //    Console.WriteLine ( "mal" );
            //}
            string[]nombres= { "Pepe", "Pedro", "Damian", "Fernando", "Dino" };
            int c = 0;
            foreach ( string nom in nombres )
            {
                if ( nom.StartsWith("D" ))
                {
                    c++;
                }
            }
            Console.WriteLine ( "Numero de veces letra D " + c );
            Console.ReadLine ();
        }
    }
}
