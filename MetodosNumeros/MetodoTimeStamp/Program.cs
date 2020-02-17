using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoTimeStamp
{
    class Program
    {
        static void Main ( string[] args )
        {
            #region clase1
            //suma de 2 horas
            //TimeSpan objeto1 = new TimeSpan ( 4, 10, 29 );
            //TimeSpan objeto2 = new TimeSpan ( 5, 15, 10 );
            //TimeSpan objeto3=  objeto1 + objeto2;
            //TimeSpan objeto4=  objeto2 - objeto1;
            //Console.WriteLine ( "Suma: " + objeto3 );
            //Console.WriteLine ( "Resta: " + objeto4 );

            //TimeSpan objeto1 = new TimeSpan ( 12, 10, 5, 12, 18 );
            ////                                dia/h/  m/  s/  ms
            //Console.WriteLine ( "Hora: " + objeto1.Hours );
            //Console.WriteLine ( "Dia: " + objeto1.Days );
            //Console.WriteLine ( "Minuto: " + objeto1.Minutes);
            //Console.WriteLine ( "Segundo: " + objeto1.Seconds);
            //Console.WriteLine ( "Milisengudos: " + objeto1.Milliseconds);
            #endregion
            #region clase2
            //TimeSpan fecha1 = new TimeSpan ( 15, 12, 15, 15, 15 );
            //TimeSpan fecha2 = new TimeSpan ( 5, 48, 15, 45, 45 );
            //TimeSpan fecha3 = new TimeSpan ( 1, 48, 15, 45, 45 );
            //TimeSpan fecha4 = new TimeSpan ( 1, 0, 0, 0, 0 );

            ////convierte de cadena a timespan
            //string fecha="17:20:10";
            //Console.WriteLine ( TimeSpan.ParseExact ( fecha, @"h\:mm\:ss", null ) );
            //TimeSpan fecha3=  fecha1 + fecha2;
            //Console.WriteLine ( fecha3.TotalDays );
            //Console.WriteLine ( fecha3.TotalHours );
            //Console.WriteLine ( fecha3.TotalMinutes);
            //Console.WriteLine ( fecha3.TotalSeconds );
            //Console.WriteLine ( fecha3.TotalMilliseconds );

            //Al igual que con el +, se suman las fechas
            //TimeSpan fecha3= fecha2.Add ( fecha1 );
            //Console.WriteLine ( fecha3 );
            //cuando el primer digito es mayor es -1, de lo contrario es 1
            //Console.WriteLine ( fecha2.CompareTo ( fecha3 ) );
            //Console.WriteLine ( TimeSpan.FromDays ( 1 ) );
            //Console.WriteLine ( TimeSpan.FromHours( 2 ) );
            //Console.WriteLine ( TimeSpan.FromMinutes ( 2 ) );
            //Console.WriteLine ( TimeSpan.FromSeconds( 9 ) );
            //Console.WriteLine ( TimeSpan.FromMilliseconds( 8 ) );
            #endregion
            Console.ReadLine ();
        }
    }
}
