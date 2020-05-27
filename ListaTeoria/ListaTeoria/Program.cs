using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTeoria
{
    class Program
    {
        static void Main( string[] args )
        {
            /*
            //SE crean los objetos
            Estudiante oEstudiante1=new Estudiante( "Felipe", 14, 19 );
            Estudiante oEstudiante2=new Estudiante( "Luis", 15, 18 );
            Estudiante oEstudiante3=new Estudiante( "Jorge", 11, 15 );
            //Se crea la lista, para los 3 objetos
            List<Estudiante> listaEStudiante = new List<Estudiante>
            {
                oEstudiante1, oEstudiante2, oEstudiante3
            };*/
            //Otra manera es instaciar los objetos dentro de la lista
            List<Estudiante>listaEstudiante2 = new List<Estudiante> { 
                new Estudiante("Felipe", 14,19),
                new Estudiante("Luis", 15, 18),
                new Estudiante("Jorge",11,15)
            };

            ////obtener promedio del 1er alumno
            ////el indice del listado comienza en 0, siendo el primer elemento el de la posicion 0
            //double promedio=( listaEstudiante2[ 0 ].nota1 + listaEstudiante2[ 0 ].nota2 ) / 2.0;
            //Console.WriteLine( promedio );

            List<Estudiante>listaEstudiante1 = new List<Estudiante> { 
                new Estudiante("Santiago", 10, 12), new Estudiante("Benito", 18, 15)
            };
            
            //se agrega un estudiante
            //listaEstudiante1.Add(new Estudiante("Pedro", 11, 16));
            //Se agrega la lsita 1 a la lista 2
            listaEstudiante2.AddRange( listaEstudiante1 );
            //Console.WriteLine( listaEstudiante2.Count );

            foreach ( Estudiante oEstudiante in listaEstudiante2 )
            {
                Console.WriteLine( oEstudiante.nombre );
            }
            //lista de nombres
            /*List<string>listaNombres = new List<string>();
            listaNombres.Add( "Luis" );
            listaNombres.Add( "Felipe" );
            listaNombres.Add( "Jorge" );
            listaNombres.Add( "Jefferson" );*/

            //recorrerlo
            //foreach ( string nom in listaNombres )
            //{
            //    Console.WriteLine( nom );
            //}

            //cuantos elementos tiene la lista?
            /*int numeroElementos = listaNombres.Count;
            Console.WriteLine(numeroElementos);*/

            Console.ReadLine();
        }
    }
}
