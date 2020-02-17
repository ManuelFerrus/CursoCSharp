using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoSubString
{
    class Program
    {
        static void Main ( string[] args )
        {
            string pasaporte ="12345678";
            string nombre = "Pepe Lucho";

            //Codigo 3 primero caracteres de pasaporte y 3 iniciales de su nombre

            string pasT=pasaporte.Substring ( 0, 3 );
            string NombreT=nombre.Substring ( 0, 3 );

            Console.WriteLine ( "Su codigo es " + pasT + NombreT );
            Console.ReadLine ();
        }
    }
}
