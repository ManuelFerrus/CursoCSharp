using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket oTicket = new Ticket();
            oTicket.setColor("Verde");
            oTicket.setTamanio(2);
            oTicket.setTipo(3);
            oTicket.setCantidad(10);

            Console.WriteLine("Precio " + oTicket.calcularPrecio());
            Console.WriteLine("Cantidad " + oTicket.getCantidad());
            Console.WriteLine("Total " + oTicket.totalPagar());
            
            Console.ReadLine();
        }
    }
}
