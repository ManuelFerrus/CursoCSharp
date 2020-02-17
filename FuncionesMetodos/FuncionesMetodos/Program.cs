using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesMetodos
{
    class Program
    {
        static void Main ( string[] args )
        {
            #region clase1
            //int sumaresultado = suma ( 6, 7 );
            //Console.WriteLine ("La suma es: "+ sumaresultado );
            //int sumaresultado2=suma ( 11, 13 );
            //Console.WriteLine ( "La suma es: " + sumaresultado2 );
            #endregion
            #region clase2
            //decimal r= calculadora ( 5, 7, '-' );
            //Console.WriteLine ( "El resultado es: " + r );
            //decimal d= calculadora ( 8, 7, '+' );
            //Console.WriteLine ( "El resultado es: " + d );
            #endregion
            #region clase3
            //decimal sueldoGanaSemanal=sueldoSemanal ( 105.6m );//m porque es decimal
            //Console.WriteLine ( "Sueldo semanal: " + sueldoGanaSemanal );
            //decimal sueldoGanaMensual=sueldoMensual ( 160m );
            //Console.WriteLine ( "Sueldo mensual: " + sueldoGanaMensual );
            //decimal sueldoGanaAnual = sueldoAnual ( 100m );
            //Console.WriteLine ( "Sueldo anual: " + sueldoGanaAnual );
            #endregion
            #region clase4
            //mensaje ( "Hola" );
            //mensaje ( "Amigo" );
            //mensaje ( "estudia" );
            //mensaje ( "mucho" );
            //noCerrarVentana ();
            #endregion
            #region clase5
            //string[] nombres= { "Pepe", "Lucho", "Felipe" };
            //imprimirArray ( nombres );
            //string[] apellidos= { "Perez", "Gomez", "Enriquez" };
            //imprimirArray ( apellidos );
            //noCerrarVentana ();
            #endregion
            #region clase6
            //imprimirRango ( 5, 7 );
            //imprimirRango ( 10, 15 );
            //noCerrarVentana ();
            #endregion
        }

        static void imprimirRango ( int inicio, int fin )
        {
            for ( int i = inicio; i <= fin; i++ )
            {
                mensaje ( i.ToString() );
            }
        }

        static void imprimirArray ( string[] array )
        {
            foreach ( string item in array )
            {
                mensaje ( item );
            }
        }

        static void mensaje ( string cadena )
        {
            Console.WriteLine (cadena);
        }

        static void noCerrarVentana ( )
        {
            Console.ReadLine ();
        }

        static decimal calculadora ( decimal a, decimal b, char operacion)
        {
            decimal resultado=0;
            switch ( operacion )
            {
                case '+':
                    resultado = a + b;
                    break;
                case '-':
                    resultado = a - b;
                    break;
                case '*':
                    resultado = a * b;
                    break;
                case '/':
                    resultado = a / b;
                    break;
                default:
                    resultado = 0;
                    break;
            }
            return resultado;
        }
        
        // semanal 7 dias
        static decimal sueldoSemanal ( decimal sueldoDiario )
        {
            return sueldoDiario * 7;
        }
        // menusal 30 dias
        static decimal sueldoMensual ( decimal sueldoDiario)
        {
            return sueldoDiario*30;
        }
        // anual 365 dias
        static decimal sueldoAnual ( decimal sueldoDiario )
        {
            return sueldoDiario * 365;
        }

        static int suma ( int a, int b )
        {
            return a+b;
        }
    }
}
