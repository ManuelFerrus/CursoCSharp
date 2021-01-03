using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Origen de datos
            List<Persona> listaPersona = new List<Persona>
            {
                new Persona {idPersona=1, nombre="Julio", apPaterno="Perez" },
                new Persona {idPersona=2, nombre="Jorge", apPaterno="Jimenez" },
                new Persona {idPersona=3, nombre="Lucho", apPaterno="Ameida" }
            };
            //2 Definimos consulta
            var consulta = from persona in listaPersona
                           orderby persona.apPaterno ascending
                           select persona;
            //3 ejecutamos
            foreach (var item in consulta)
            {
                Console.WriteLine("La persona " + item.nombre + " su apellido es " + item.apPaterno);
            }
            Console.ReadLine();
        }
    }
}
