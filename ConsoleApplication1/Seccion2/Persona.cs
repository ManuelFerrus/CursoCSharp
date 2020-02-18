using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion2
{
    public class Persona //Se hace publica la clase
    {
        //constructror explicito (por defecto
        public Persona ( )
        {
 
        }
        //Constructor manual
        public Persona ( string nombre, string apPaterno, string apMaterno, int edad, int sueldo )
        {
            this.nombre = nombre;
            //this.propiedad = variable;
            this.apPaterno = apPaterno;
            this.apMaterno = apMaterno;
            this.edad = edad;
            this.sueldo = sueldo;
        }
        //Lo que queremos almacenar PROPIEDADES
        public string nombre { get; set; }
                                    //set, permite asignarle valores a una propiedad
        public string apPaterno { get; set; }
        public string apMaterno { get; set; }
                                //get, permite leer el valore de una propiedad
        public int edad { get; set; }
        public double sueldo { get; set; }

        public string nombreCompleto (  )
        {
            return nombre + " " + apPaterno + " " + apMaterno;
        }

        public double calcularSueldoAnual ( )
        {
            return sueldo * 12;
        }

        public static string saludo ( string nombre )
        {
            //calcularSueldoAnual ( );
            //En un metodo static, solo puedes hacer consumo de metodos static
            return "Hola como estas " + nombre;
        }

        public static string saludo ( string nombre, string apellidoPaterno)
        {
            //En la sobre carga del metodo, puede existir un metodo que tenga el mismo nombre, pero sus parametros para recibir sean diferentes (esto se llama firma)
            return "Hola como estas " + nombre + " " +apellidoPaterno;
        }
    }
}
