using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    class Program
    {
        static void Main( string[] args )
        {
            Stack pilas = new Stack();
            pilas.Push( "Lunes" );
            pilas.Push( "Martes" );
            pilas.Push( "Miercoles" );
            pilas.Push( "Jueves" );
            pilas.Push( "Viernes" );
            pilas.Push( "Sabado" );
            pilas.Push( "Domingo" );

            //al mostrar los elementos salen del ultimo al primero
            //foreach ( var item in pilas )
            //{
            //    Console.WriteLine( item );
            //}
            //pilas.Clear();//borro los elementos

            string[] diasSemana = new string[ 7 ];
            pilas.CopyTo( diasSemana, 0 ); //se copia a un array comenzando por el indice 0

            //foreach ( string dia in diasSemana )
            //{
            //    Console.WriteLine( dia );
            //}

            pilas.Pop(); //borra el primer elemento en la pila (domingo)
            pilas.Pop(); //borra el primer elemento en la pila Actual (sabado)
            foreach ( string pila in pilas )
            {
                Console.WriteLine( pila );
            }
            Console.WriteLine( "El numero de elementos es " + pilas.Count );

            Console.ReadLine();
        }
    }
}
