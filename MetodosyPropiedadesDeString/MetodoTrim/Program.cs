using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoTrim
{
    class Program
    {
        static void Main ( string[] args )
        {
            string apellido =" Gonzales Prada ";
            Console.WriteLine ( apellido.Length );
            Console.WriteLine ( apellido.Trim().Length );

            string objeto= " Mesa ";
            Console.WriteLine ("TrimStart "+  objeto.TrimStart ().Length );
            Console.WriteLine ( "TrimEnd " + objeto.TrimEnd ().Length );
            
            Console.ReadLine ();
        }
    }
}
