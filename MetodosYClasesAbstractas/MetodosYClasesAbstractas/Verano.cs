using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosYClasesAbstractas
{
    public class Verano:Estacion // Se hace la herencia
    {
        public override void sensacion() //para que haya sobre escritura debe de haber herencia
        {
            Console.WriteLine( "Calor" );
        }
    }
}
