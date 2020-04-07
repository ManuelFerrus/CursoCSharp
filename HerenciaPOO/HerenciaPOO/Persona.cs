using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPOO
{
    //SuperClase ( de aqui heredan sus hijos, propiedades y metodos)
    public class Persona
    {
        public string nombre { get; set; }
        public string apPaterno { get; set; }
        public string apManterno { get; set; }
        public int edad { get; set; }

        public string nombreCompleto()
        {
            return this.nombre + " " + this.apPaterno + " " + this.apManterno;
        }
    }
}
