using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasPropiedadesYMetodos
{
    class Program
    {
        static void Main( string[] args )
        {
            Cliente oCliente1 = new Cliente( "Pedro", "Garcia", "Romero", 17, "ABC Peru" );
            Cliente oCliente2 = new Cliente( "Luis", "De la Cruz", "Garma", 19, "CDE Peru" );
            Cliente oCliente3 = new Cliente( "Jorge", "Peceros", "Aurelio", 21, "OIU Peru" );
            Cliente oCliente4 = new Cliente( "Lucho", "Carmona", "Pedrito", 28, "WER Peru" );
            Cliente oCliente5 = new Cliente( "Jesus", "Valle", "Roldan", 36, "RTY Peru" );

            List<Cliente>listaClientes = new List<Cliente> { 
                oCliente1, oCliente2, oCliente3, oCliente4, oCliente5
            };

            listaClientes.Add( new Cliente( "Nelly", "Sarmiento", "Garcia", 40, "DER" ) );


            List<Cliente> listaCLientes2 = new List<Cliente> { 
                new Cliente ("Adrian", "Ugarriza","Perez", 20, "peo"),
                new Cliente("Rodrigo", "Cuba", "Affonso", 25, "oia")
            };
            //si se intenta con el .add no te permitira, porque estas agregando una lista
            //SE agrega al final de la lista
            //listaClientes.AddRange( listaCLientes2 );
            //Se inserta en la posicion deseada
            listaClientes.InsertRange( 2, listaCLientes2 );

            //eliminamos a todas las personas que su nombre termina con o
            //listaClientes.RemoveAll( p => p.nombre.EndsWith( "o" ) );
            //elimina solo el primer registro que encuentre 
            //Cliente oClienteResultado = listaClientes.Find( p => p.nombre.EndsWith( "o" ) );
            //listaClientes.Remove( oClienteResultado );

            listaClientes.RemoveAt( 0 );//elimina de aucerdo a una posicion
            //se busca el valor y se retorna el primero encontrado
                                                          // Vriable de rangoo, para recorrer la lista
            //Cliente oClienteResultado = listaClientes.Find( p => p.nombre.Equals( "Adrian" ) );
            //if ( oClienteResultado != null ) //si no lo encuentra retorna nulo
            //    Console.WriteLine( oClienteResultado.apPaterno ); //Solo devulebe la primera coincidencia
            //else
            //    Console.WriteLine( "No se encontro el objeto" );
            
            //findall, retorna una lista
            //findall, retorna todas las iteraciones
            //List<Cliente> lista = listaClientes.FindAll(p=>p.nombre.StartsWith("J"));
            //foreach ( Cliente oCliente in lista )
            //{
            //    Console.WriteLine( oCliente.nombre + " " + oCliente.apPaterno + " " + oCliente.apMaterno );
            //}
            //listaClientes.Clear();//se limpia la lista

            //listaClientes.Add( new Cliente( "Pepe", "Gonzales", "Prada", 45, "fgr" ) ); //agrega al final de la lista
            //listaClientes.Insert(1, new Cliente( "Pepe", "Gonzales", "Prada", 45, "fgr" ) ); //agrega en la posicion indicada

            foreach ( Cliente oCliente in listaClientes )
            {
                Console.WriteLine( oCliente.nombre );
            }
            
            //Console.WriteLine("numero de elementos " + listaClientes.Count );
            Console.ReadLine();
        }
    }
}
