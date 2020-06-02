using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOf
{
    class Program
    {
        static void Main( string[] args )
        {
            string distrito = "Puente uuuuuu Piedra";
            //                 0123456789012
            //IndexOf busca un caracter en una cadena, retorna la posicion del indice donde se encuentra, comenzando en 0
            //busca de izq a der, y retorna la primera vez que lo encuentra
            //si no se le pone el segundo parametro busca desde el indice 0
            Console.WriteLine( "Index of: " + distrito.IndexOf( "u") );
            //el segundo parametro sirve para indicar a partir de que indice comenzara a buscar
            Console.WriteLine( "Index of: " + distrito.IndexOf( "u", 2 ) ); 
            
            //Busca de der a izq
            Console.WriteLine( "Last Index Of: " + distrito.LastIndexOf( "u" ) );
            //Si se busca un valor que no exista en la cadena, retorna -1
            Console.WriteLine( "Inidice: " + distrito.LastIndexOf( "j" ) );

            if ( distrito.IndexOf( "m" ) > -1 )
                Console.WriteLine( "Si se encontro la m" );
            else
                Console.WriteLine( "No se encontro la m" );

            Console.ReadLine();
        }
    }
}
