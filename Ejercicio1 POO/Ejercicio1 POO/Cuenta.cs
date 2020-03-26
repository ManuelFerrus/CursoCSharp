using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_POO
{
    public class Cuenta
    {
        private string titular { get; set; }
        private double cantidad { get; set; }

        //propiedad titular {get; set;}
        public string getTitular()
        {
            return titular;
        }

        public void setTitular(string titular)
        {
            this.titular = titular;
        }

        //propiedad cantidad {get; set;}
        public double getCantidad()
        {
            return cantidad;
        }

        public void setCantidad(double cantidad)
        {
            if (cantidad > 0) this.cantidad = cantidad;
            else this.cantidad = 0;
        }

        //metodos
        public void Ingresar(double cantidad)
        {
            this.cantidad += cantidad;
        }

        public void Retirar(double cantidad)
        {
            this.cantidad -= cantidad;
        }
    }
}
