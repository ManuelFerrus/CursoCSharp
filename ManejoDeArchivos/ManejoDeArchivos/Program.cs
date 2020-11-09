using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeArchivos
{
    class Program
    {
        static void Main( string[] args )
        {
            //string ruta = @"C:\ClaseArchivos\Alumnos"; //se le pone el arroba para que reconozca  la diagonal invertida \
            //Directory.CreateDirectory( ruta ); // Se crea la carpeta
            //Directory.Delete( ruta ); // se borra la carpeta (tiene que ser un directorio vacio)
            //Directory.Delete( ruta, true ); // se borra la carpeta (aunque tenga archivos dentro)
            //List <string> lista = Directory.EnumerateDirectories( ruta ).ToList(); // enlistamos todos los subdirectorios de un directorio
            //List <string> lista = Directory.EnumerateDirectories( ruta, "*A" ).ToList(); // enlistamos los subdirectorios de un directorio, aplicando un filtro, no distingue mayusculas/minusculas
            //foreach ( string elemento in lista)
            //{
            //    Console.WriteLine( elemento );
            //}

            //List<string> lista = Directory.EnumerateFiles( ruta ).ToList(); //enlistamos todos los archivos
            //List<string> lista = Directory.EnumerateFiles( ruta, "T*" ).ToList(); //enlistamos los archivos, aplicando filtro
            //foreach ( string elemento in lista )
            //{
            //    Console.WriteLine( elemento ); //se muestran todos los archivos, con sus extenciones
            //}

            //DirectoryInfo dir = new DirectoryInfo( @"C:\ClaseArchivos\Cursos\EntityFramework" );
            //dir.Create(); // se crea el directorio
            //dir.Delete( true ); // se borra el directorio
            //Console.WriteLine( dir.Parent );//regresa el nombre del directorio padre, no toda la ruta
            //Console.WriteLine( dir.Root ); // nos regresa la unidad donde se encuentra la carpeta
            //if ( dir.Exists ) //verificamos si existe o no el directorio
            //{
            //    Console.WriteLine( "Existe el directorio" );
            //}
            //else
            //{
            //    Console.WriteLine( "No existe directorio" );
            //}

            //string ruta = @"C:\ClaseArchivos\CSharp.txt";
            //File.Create( ruta ); //Crea el archivo
            //List<string>nombres = new List<string>(); //SE crea la lista de los nombres
            //nombres.Add( "Pedro" );
            //nombres.Add( "Luis" );
            //nombres.Add( "José" );
            //nombres.Add( "Santiago" );
            //nombres.Add( "Nelly" );
            //File.AppendAllLines( ruta, nombres ); //Se agrega todos los datos en el archivo

            //string nombres = "Pedro Luis José Santiago Nelly";
            //File.AppendAllText( ruta, nombres );

            //string ruta = @"C:\ClaseArchivos\Alumnos";
            //List<string> lista = Directory.EnumerateFileSystemEntries(ruta, "*s").ToList(); //Buscamos todos los archivos y carpetas que estan en la ruta especificada
            //foreach (string item in lista)
            //{
            //    Console.WriteLine(item); //Se imprimen los elementos
            //}

            //string directorioActual = Directory.GetCurrentDirectory(); //Directorio donde se ejecuta la aplicacion
            //string unidad = Directory.GetDirectoryRoot( directorioActual ); //Regresa el nombre de la unidad
            //Console.WriteLine( "Directorio Actual " + directorioActual );
            //Console.WriteLine( "Unidad " + unidad );

            //string rutaInicio = @"C:\ClaseArchivos\Alumnos";
            //string rutaFinal = @"C:\RutaMover2";
            //Directory.Move( rutaInicio, rutaFinal ); //Se mueven los archivos que estan dentro de la carpeta a donde se le indique

            //copiar archivo
            //string rutaOrigen =@"C:\ClaseArchivos\examen.txt";
            //string rutaDestino=@"C:\Mover\examen.txt";
            //File.Copy( rutaOrigen, rutaDestino );

            //string rutaOrigen = @"C:\ClaseArchivos\move.txt";
            //string rutaDestino = @"C:\Mover\move.txt";
            //using ( StreamWriter sw = File.CreateText( ruta ) ) //si el archivo ya existe, lo borra, lo crea y añade el texto, si lo que deseas es añadir texto, te recomiendo el AppendAllText
            //{
            //    sw.Write( "Hola" );
            //    sw.Write( "Amigos" );
            //    sw.Write( "Compañeros" );
            //}

            //File.Delete( ruta );//eliminamos el archivo
            //File.Encrypt( ruta ); //solo el usuario que lo creo, lo puede abrir y editar
            //File.Move( rutaOrigen, rutaDestino ); //Lo quita de un lado y lo manda a otro lugar

            string ruta =@"C:\ClaseArchivos\Imagenes\Imagen.jpg";
            string rutaDestino =@"C:\Imagen\Imagen.jpg";
            byte[] archivo= File.ReadAllBytes( ruta ); // convertimos la imagen en bytes
            File.WriteAllBytes( rutaDestino, archivo ); // escribimos los bytes, para restaurar la imagen
            Console.ReadLine();
        }
    }
}
