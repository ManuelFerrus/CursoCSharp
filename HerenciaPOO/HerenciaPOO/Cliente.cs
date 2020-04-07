using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPOO
{
                        //Hereda de persona
    public class Cliente:Persona
    {
        public string direccion { get; set; }
        public DateTime fechaNacimiento { get; set; }
    }
}
