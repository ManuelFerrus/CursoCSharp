using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_POO
{
    public class Ticket
    {
        private string color;
        private double tamanio;
        private int tipo;
        private int cantidad;

        //metodos de acceso
        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public double getTamanio()
        {
            return tamanio;
        }

        public void setTamanio(double tamanio)
        {
            this.tamanio = tamanio;
        }

        public int getTipo()
        {
            return tipo;
        }

        public void setTipo(int tipo)
        {
            if (tipo == 1 || tipo == 2 || tipo == 3) this.tipo = tipo;
            else this.tipo = 1;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public void setCantidad(int cantidad)
        {
            if (cantidad > 0) this.cantidad = cantidad;
            else this.cantidad = 1;
        }

        public double calcularPrecio()
        {
            int tipo = this.tipo;
            switch (tipo)
            {
                case 1: return 5; //break; //no es necesario pronerlo, ya que con el return, en automatico se sale del flujo
                case 2: return 8;
                case 3: return 10;
                default: return 0;
            }
        }

        public double totalPagar()
        {
            double precio = calcularPrecio();
            return precio * this.cantidad;
        }
    }
}
