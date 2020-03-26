using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calificaciones del 0 al 20
            Alumno oAlumno = new Alumno();
            oAlumno.setNombreAlumno("Coco");
            oAlumno.setNota1(12);
            oAlumno.setNota2(18);
            oAlumno.setNota3(20);
            oAlumno.setNota4(11);

            Console.WriteLine("Promedio 2 primeras notas " + oAlumno.promedioDosPrimerasNotas());
            Console.WriteLine("Promedio 2 ultimas notas " + oAlumno.promedioDosUltimasNotas());
            Console.WriteLine("Promedio 4 notas " + oAlumno.promedioCuatroNotas());

            Console.ReadLine();
        }
    }
}
