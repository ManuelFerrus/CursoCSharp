using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosYClasesAbstractas
{
    class Invierno:Estacion
    {
        public override void sensacion() //Se tiene que hacer la sobreescritura del metodo abstracto, si tienes 5 metodos abstractos tienes que sobreescribir los 5
        {
            Console.WriteLine( "Frio" );
        }
    }
}
