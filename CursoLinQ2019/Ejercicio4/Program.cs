using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 fuente de datos
            List<Empleado> listaEmpleado = new List<Empleado> {
                new Empleado {idEmpleado=1, nombre="Vanessa", sueldo=1000 },
                new Empleado {idEmpleado=2, nombre="Jorge", sueldo=800 },
                new Empleado {idEmpleado=3, nombre="Carmen", sueldo=1500 },
                new Empleado {idEmpleado=4, nombre="Aurora", sueldo=1200 }
            };
            //2 definimos consulta
            var consulta = from empleado in listaEmpleado
                           where empleado.sueldo >= 1100
                           select empleado;
            //3 ejecutamos la consulta
            foreach (var item in consulta)
            {
                Console.WriteLine("El emplado con nombre " + item.nombre + " y su sueldo es " + item.sueldo);
            }
            Console.ReadLine();
        }
    }
}
