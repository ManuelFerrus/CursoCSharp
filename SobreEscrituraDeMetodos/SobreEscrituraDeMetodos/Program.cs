using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreEscrituraDeMetodos
{
    class Program
    {
        static void Main( string[] args )
        {
            Pera oPera = new Pera();
            oPera.color();

            Fresa oFresa = new Fresa();
            oFresa.color();
            //Para poder sobre escribir el valor, se tiene que ir a la clase padre, en este caso, clase Fruta
            Console.ReadLine();
        }
    }
}
