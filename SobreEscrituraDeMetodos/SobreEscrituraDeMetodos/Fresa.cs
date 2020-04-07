using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreEscrituraDeMetodos
{
    public class Fresa:Fruta
    {
        public override void color()//override, permite la sobre escritura del metodo virtual de la clase padre
        {
            Console.WriteLine( "Rojo" );
        }
    }
}
