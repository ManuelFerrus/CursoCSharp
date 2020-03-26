using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta oCuenta = new Cuenta();
            oCuenta.setTitular("Alfredo Gonzalez");
            oCuenta.Ingresar(4000);
            oCuenta.Retirar(1500);
            oCuenta.Ingresar(500);

            Console.WriteLine("El dinero que tiene es "+oCuenta.getCantidad());
            Console.ReadLine();
        }
    }
}
