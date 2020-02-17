using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoToString
{
    class Program
    {
        static void Main ( string[] args )
        {
            short a=10;
            int b=20;
            long c= 30;

            string cadena1=a.ToString ();
            string cadena2=b.ToString ();
            string cadena3=c.ToString ();
            Console.WriteLine ( cadena1);
            Console.WriteLine ( cadena2 );
            Console.WriteLine ( cadena3 );

            Console.ReadLine ();
        }
    }
}
