using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosArray
{
    class Program
    {
        static void Main ( string[] args )
        {
            int[]numeros= { 5, 18, 21, 22, 13 };
            string[]nombres= { "Pedro", "Luis", "Jose", "Felipe" };

            #region clase1
            //Length - Numeros de elementos de un arrya
            int longitud=numeros.Length;
            //Console.WriteLine ( "El numero de elementos es: " + longitud );
            //find - Busca el primer elemento que cumpla una condicion
            //Sacar el primer elemento del array que sea mayor a 15
            int mayorA15=Array.Find ( numeros, p => p > 15 );
                                //busca en todos los item -- //Filtra que sea mayor a 15. Solo devulve el primero NO TODOS!!!!
            //Console.WriteLine ( "El primer elemento mayor a 15 es: " + mayorA15 );
            //findall -- devuelve todos que cumplan con una condicion
            //int[]numerosfiltrados = Array.FindAll ( numeros, el => el > 15 );
            //foreach ( int el in numerosfiltrados )
            //{
            //    Console.WriteLine ( el );
            //}

            //indexof - verifica si existe un valor en el array
            //retorna el indice donde se encuentra 
            //int indice=Array.IndexOf ( numeros, 21 );
            //if ( indice>0 )
            //{
            //    Console.WriteLine ( "Existe el valor" );
            //}
            //else
            //{
            //    Console.WriteLine ( "No existe" );
            //}
            #endregion
            //findlast, busca el primer elemento que cumpla una condicion, de izquierda a derecha
            #region clase2
            //int numero = Array.FindLast ( numeros, p => p > 20 );
            //Console.WriteLine ( "El ultimo elemento es :" + numero );
            //el indice del primero elemento mayor a 10
            //int indice=Array.FindIndex ( numeros, p => p > 10 );
            //Console.WriteLine ( "El indice es: " + indice );
            //Console.WriteLine ( "su valor es: " + numeros[ indice ] );
            //findlastindex - busca el ultimo elemento, busca de derecha a izquierda y retorna el indice en el que se encuentra
            //int indiceultimo=Array.FindLastIndex ( numeros, p => p > 14 );
            //Console.WriteLine ( "El indice es: " + indiceultimo );
            //Console.WriteLine ( "Su valor es: " + numeros[ indiceultimo ] );
            //exists, verifica si existe o no
            bool exito = Array.Exists ( nombres, p => p.StartsWith ( "J" ) );
            if ( exito )
            {
                Console.WriteLine ( "hay elementos que cumplen la condicion" );
            }
            else
            {
                Console.WriteLine ( "No hay elementos" );
            }
            #endregion
            Console.ReadLine ();
        }
    }
}
