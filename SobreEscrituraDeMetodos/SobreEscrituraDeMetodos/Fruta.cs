using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreEscrituraDeMetodos
{
    public class Fruta
    {
        public virtual void color() //Metodo a sobreescribir, sin virtual, no podras sobre-escribir
        {
            Console.WriteLine( "Tiene varios colores." );
        }
    }
}
