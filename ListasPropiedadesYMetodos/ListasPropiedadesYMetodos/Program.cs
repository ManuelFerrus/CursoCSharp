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
                new Cliente ("Adrian", "Ugarria","Perez", 20, "peo"),
                new Cliente("Rodrigo", "Cuba", "Affonso", 25, "oia")
            };
            //si se intenta con el .add no te permitira, porque estas agregando una lista
            listaClientes.AddRange( listaCLientes2 );
            listaClientes.Clear();//se limpia la lista
            foreach ( Cliente oCliente in listaClientes )
            {
                Console.WriteLine( oCliente.nombre );
            }
            
            Console.WriteLine("numero de elementos " + listaClientes.Count );
            Console.ReadLine();
        }
    }
}
