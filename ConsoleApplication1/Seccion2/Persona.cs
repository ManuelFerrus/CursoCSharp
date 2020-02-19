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
        //Para el encapzulamiento las propiedades deben de ser private
        private string nombre { get; set; }
                                    //set, permite asignarle valores a una propiedad
        private string apPaterno { get; set; }
        private string apMaterno { get; set; }
                                //get, permite leer el valore de una propiedad
        private int edad { get; set; }
        private double sueldo { get; set; }
        //--

        //Modificadores
        #region modificadores Encapzulamiento
        public string getNombre ( )
        {
            return nombre;
        }
        //los Set son void
        public void setNombre ( string nombre )
        {
            this.nombre = nombre;
        }

        public string getApPaterno ( )
        {
            return apPaterno;
        }

        public void setApPaterno ( string apPaterno )
        {
            this.apPaterno = apPaterno;
        }

        public string getApMaterno ( )
        {
            return apMaterno;
        }
        
        public void setApMaterno ( string apMaterno )
        {
            this.apMaterno = apMaterno;
        }

        //Modificador para la propiedad edad
        public int getEdad ( )
        {
            return edad;
        }
        
        public void setEdad ( int edad )
        {
            if ( edad > 0 ) this.edad = edad;
            else this.edad = 0; //Se le asigna un valor por defecto a la propiedad
        }
        //Modificador para la propiedad sueldo
        public double getSueldo ( )
        {
            return sueldo;
        }

        public void setSueldo ( double sueldo )
        {
            if ( sueldo > 0 ) this.sueldo = sueldo;
            else this.sueldo = 0; //Se le asigna un valor por defecto a la propiedad
        }
        #endregion
        //--
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
