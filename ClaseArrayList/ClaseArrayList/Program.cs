using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseArrayList
{
    class Program
    {
        static void Main( string[] args )
        {
            //Ctrl . te dice que falta instansear
            ArrayList cursos = new ArrayList();
            cursos.Add( "Matematicas" );
            cursos.Add( "Comunicacion" );
            cursos.Add( "Lenguaje" );
            cursos.Add( 50 );
            cursos.Add( 45.6 );
            //ArrayList soporta cualquier tipo de dato

            //Console.WriteLine( "Primer valor " + cursos[ 0 ] );
            //Console.WriteLine( "Numero de elemantos " + cursos.Count );
            //para recorrer un arraylist, la variable tiene que ser tipo var
            //tiene los mismos metodos y propiedades que una lista

            cursos.Insert( 0, "Educacion fisica" );//se inserta un nuevo valor en el indice 0
            foreach ( var curso in cursos )
            {
                Console.WriteLine( curso );
            }
            Console.ReadLine();
        }
    }
}
