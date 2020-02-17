using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoRemove
{
    class Program
    {
        static void Main ( string[] args )
        {
            string codigo = "A20191528";
            //eliminar los 2 primeros caracteres
            Console.WriteLine ( "Nueva cadena " + codigo.Remove ( 1, 3 ) );
            Console.ReadLine ();

        }
    }
}
