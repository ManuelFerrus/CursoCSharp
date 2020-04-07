using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosYClasesAbstractas
{
    class Program
    {
        static void Main( string[] args )
        {
            Invierno oInvierno = new Invierno();
            oInvierno.sensacion();

            Verano oVerano = new Verano();
            oVerano.sensacion();

            //Estacion oEstacion = new Estacion(); //No se puede crear un objeto de una clase abstracta

            Console.ReadLine();
        }
    }
}
