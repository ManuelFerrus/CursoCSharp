using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionDiccionario
{
    class Program
    {
        static void Main( string[] args )
        {
            //1 (Domingo)
            //2 (Lunes)..
            //definimos el diccionario
            Dictionary<int, string> diccionario = new Dictionary<int,string>();
            //almacenamos valores
            //nos evitamos crear la clase para almacenar estos dos valores
            diccionario.Add(1, "Domingo");
            diccionario.Add(2, "Lunes");
            diccionario.Add(3, "Martes");
            diccionario.Add(4, "Miercoles");
            diccionario.Add(5, "Jueves");
            diccionario.Add(6, "Viernes");
            //diccionario.Add(7, "Sabado");
            diccionario[ 7 ] = "Sabado"; //tambien se agrega de esta manera
            diccionario[ 8 ] = "Enero";
                        //key  //value
            //diccionario.Clear();//limpia el diccionario
            diccionario.Remove( 8 ); //Borramos la llave 8
            Console.WriteLine( "El numeo de elementos es " + diccionario.Count );

            //buscar por numero de llave
            //if ( diccionario.ContainsKey( 6 ) )
            //    Console.WriteLine( "Existe llave" );
            //else
            //    Console.WriteLine( "No existe llave" );

            ////buscar por numero de valor
            //if (diccionario.ContainsValue("Sabado"))
            //    Console.WriteLine( "Existe dia" );
            //else
            //    Console.WriteLine( "No existe dia" );

            
            //imprimeir valores, sin las llaves
            foreach ( var val in diccionario.Values )
            {
                Console.WriteLine( val );
            }

            Console.ReadLine();
        }
    }
}
