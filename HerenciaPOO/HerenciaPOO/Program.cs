using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado emp = new Empleado();
            emp.nombre = "Julio";
            emp.apPaterno = "Hernandez";
            emp.apManterno = "Felipe";
            emp.sueldo=3000;
            emp.fechaContrato = DateTime.Now;
            string nombreCompleto = emp.nombreCompleto();
            Console.WriteLine( nombreCompleto );
            Console.WriteLine( "fecha de contrato " + emp.fechaContrato + " Sueldo " + emp.sueldo );

            Cliente oCliente = new Cliente();
            oCliente.nombre = "Joseph";
            oCliente.apPaterno="de la Cruz";
            oCliente.apManterno="Aurelio";
            oCliente.edad=22;
            oCliente.direccion="ABC";
            oCliente.fechaNacimiento=DateTime.Now;
            string nombreComp =oCliente.nombreCompleto();
            Console.WriteLine("El cliente es "+nombreComp);
            Console.ReadLine();
        }
    }
}
