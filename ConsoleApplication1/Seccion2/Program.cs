using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion2
{
    class Program
    {
        static void Main ( string[] args )
        {
            #region Tarea
            #region ejercicio 3
            /*se tiene el siguiente array , 
             * hallar la suma de los elementos que son mayores a 15
             * int [] números = {5,8,6,4,8,25,4,2,8,12,45,12,6,7,8}
             */
            //int [] numeros = { 5, 8, 6, 4, 8, 25, 4, 2, 8, 12, 45, 12, 6, 7, 8 };
            //int suma=0;
            //foreach ( int num in numeros)
            //{
            //    if ( num > 15 )
            //    {
            //        suma += num;
            //    }
            //}
            //Console.WriteLine ( "La suma es de " + suma );
            #endregion
            #region ejercicio 2
            /*Se tiene el siguiente array de números 
             * indicar cuantos números de tres cifras positivos hay
             * int[] valores= {721,9,423,56,23,34,966,78,79,3664,12,5516,15};*
             */
            //int[] valores= { 721, 9, 423, 56, 23, 34, 966, 78, 79, 3664, 12, 5516, 15 };
            //int iContador=0;
            //foreach ( int val in valores )
            //{
            //    if ( val >= 100 && val <= 999 )
            //    {
            //        iContador++;
            //    }
            //}
            //Console.WriteLine ( "Hay " + iContador + " números positivos de 3 cifras" );
            #endregion
            #region ejercicio 1
            /*Se tiene el siguiente array de números . 
             * Calcular cuantos elementos son pares y cuantos son impares
             * int[] valores= {7,9,23,56,23,34,66,78,79,34,12,16,15};
             */
            //int[] valores= { 7, 9, 23, 56, 23, 34, 66, 78, 79, 34, 12, 16, 15 };
            //int iPares=0, iImpares=0;
            //foreach ( int val in valores )
            //{
            //    if ( val % 2 == 0 )
            //    {
            //        iPares++;
            //    }
            //    else
            //    {
            //        iImpares++;
            //    }
            //}
            //Console.WriteLine ( "Se tiene " + iPares + " números pares" );
            //Console.WriteLine ( "Se tiene " + iImpares + " números impares" );
            #endregion
            #endregion
            #region ejercicio array 6
            //int [] numeros = { 10, 4, 6, 11, 145, 3456, 22, 44, 1, -6, -8 };
            //int contUnaCifra=0, contDosCifras=0;
            //foreach ( int numero in numeros )
            //{
            //    if ( numero>= 0 && numero<=9 ) contUnaCifra++;
            //    if ( numero>=10 && numero<=99 ) contDosCifras++;
            //}
            //Console.WriteLine ( "Hay " + contUnaCifra + " numeros de una cifra" );
            //Console.WriteLine ( "Hay " + contDosCifras + " numeros de dos cifra" );
            #endregion
            #region ejercicio array 5
            //int[]numeros= { 4, 5, -4, 7, 8, -2, 12, 176, -6, -1 };
            //int contadorPositivos=0, contadorNegativos=0, sumapositivos=0, sumanegativos=0 ;
            //foreach ( int num in numeros )
            //{
            //    if ( num>=0 )
            //    {
            //        contadorPositivos++;
            //        sumapositivos += num;
            //    }
            //    else
            //    {
            //        contadorNegativos++;
            //        sumanegativos += num;
            //    }
            //}
            //Console.WriteLine ( "El total de numero positivos son " + contadorPositivos );
            //Console.WriteLine ( "La suma de los positivos son: " + sumapositivos );
            //Console.WriteLine ( "El total de numero negativos son " + contadorNegativos);
            //Console.WriteLine ( "La suma de los negativos son: " + sumanegativos);
            #endregion
            #region ejercicio array 4
            ////suma solo de pares
            //int []numeros= { 1, 3, 2, 4, 11, 19 };
            //int suma=0;
            //foreach ( int numero in numeros )
            //{
            //    if ( numero % 2 == 0 )
            //    {
            //        suma += numero;
            //    }
            //}
            //Console.WriteLine ( "La suma de los pares es " + suma );
            #endregion
            #region ejercicio array 3
            //int[]numeros= { -100, 56, -20, 15, -12, -20 };
            //int c = 0;
            //foreach ( int numero in numeros )
            //{
            //    if ( numero >= 0 )
            //    {
            //        //Console.WriteLine ( numero );
            //        c++;
            //    }
            //}
            //Console.WriteLine ( "La cantidad de positivos son: " + c );
            #endregion
            #region ejercicio array 2
            //int []numeros= { 31, 34, 37, 46, 20, 42 };
            ////mayores  a 18 y menores a 35
            //foreach ( int num in numeros )
            //{
            //    if ( num > 18 && num < 35 )
            //    {
            //        Console.WriteLine ( num );
            //    }
            //}
            #endregion
            #region ejercicio array
            //int []numeros=new int[ 4 ];
            //for ( int i = 0; i < 4; i++ )
            //{
            //    Console.WriteLine ( "Ingrese el primer numero: " + ( i + 1 ) );
            //    numeros[ i ] = int.Parse ( Console.ReadLine () );
            //}
            //Console.WriteLine ( "Los numero ingresados son:" );
            //foreach ( int num in numeros )
            //{
            //    Console.WriteLine ( num );
            //}
            //int suma=numeros[ 0 ] + numeros[ numeros.Length - 1 ];
            //Console.WriteLine ( "Suma: " + suma );
            #endregion
            #region arrays de arrays (matriz)
            //string[,] nombresCompleto= 
            //{
            //    {"Julio", "Nieves", "Sandoval"},
            //    {"Ricardo", "De la Cruz", "Muraryari"},
            //    {"Rolando", "Garcia", "Peceros"}
            //};
            //Console.WriteLine(nombresCompleto[ 0, 0 ]);
            //Console.WriteLine ( nombresCompleto[ 0, 2 ] );
            #endregion
            #region agregar elementos
            //int[]notas=new int[ 5 ];
            //notas[ 0 ] = 10;
            //notas[ 1 ] = 20;
            //notas[ 2 ] = 15;
            //notas[ 3 ] = 12;
            //notas[ 4 ] = 18;
            //foreach ( int numero in  notas)
            //{
            //    Console.WriteLine ( numero );
            //}
            #endregion
            #region lectura con for
            //string[]nombres= { "Pepe", "Jose", "Gerardo" };
            //int nelementos=nombres.Length;
            //for ( int i = 0; i < nelementos; i++ )
            //{
            //    Console.WriteLine ( nombres[ i ] );
            //}
            #endregion
            #region lectura con foreach
            //string[]nombres= { "Pepe", "Jose", "Gerardo" };
            //foreach ( string nom in nombres)
            //{
            //    Console.WriteLine ( nom );
            //}
            ////----
            //int [] notas= { 10, 20, 15, 12, 18 };
            //foreach ( int nota in notas)
            //{
            //    Console.WriteLine ( nota );
            //}
            #endregion
            #region ArrayEnteros
            //int [] notas= { 11, 15, 12, 10, 8, 7, 3, 4 };
            //Console.WriteLine ( "Numero de elementos " + notas.Length );
            //Console.WriteLine ( "Nota 1 " + notas[ 0 ] );
            //Console.WriteLine ( "Ultimo elemento " + notas[ notas.Length - 1 ] );
            #endregion
            #region arrayString
            /*
            string[]nombres= { "Pepe", "Jose", "Gerardo" };
            //indice            0          1        2
            Console.WriteLine ( "El numero de elementos es " + nombres.Length );
            Console.WriteLine ( "El primer nombres es " + nombres[ 0 ] );
            Console.WriteLine ( "El ultimo nombres es " + nombres[ 2 ] );*/
            #endregion

            #region clases1
            //Persona oPersona = new Persona ( );
            //oPersona.nombre = "Julio";
            //oPersona.apPaterno = "Nieves";
            //oPersona.apMaterno = "Sandoval";
            //oPersona.edad = 45;
            //oPersona.sueldo = 5000;
            //Console.WriteLine ( oPersona.nombreCompleto ( ) );
            //Console.WriteLine ( oPersona.calcularSueldoAnual ( ) );

            //Los metodos estaticos no se aplican a un objeto
            //oPersona.saludo("")
            // si es un metodo estatico, es el nombre de la clase . metodo
            //string saludo = Persona.saludo ( "Felipe" );
            //Console.WriteLine ( saludo );
            //string saludo1=  Persona.saludo ( "Felipe" );
            //string saludo2=  Persona.saludo ( "Jorge", "Lopez" );
            //Console.WriteLine ( saludo1 );
            //Console.WriteLine ( saludo2 );
            //Persona oPersona2 = new Persona ( );
            //oPersona2.nombre = "Ricardo";
            //oPersona2.apPaterno = "De la Cruz";
            //oPersona2.apMaterno = "Murayari";
            //oPersona2.edad = 32;
            //oPersona2.sueldo = 4000;
            //Console.WriteLine ( oPersona2.nombreCompleto ( ) );
            //Console.WriteLine ( oPersona2.calcularSueldoAnual ( ) );

            /* 
             *Console.WriteLine ( oPersona.nombre );
            Console.WriteLine ( oPersona2.apMaterno );
              */
            #endregion
            #region clases2
            //Usuario oUsuario = new Usuario ( );
            //oUsuario.nombreUsuario = "lrol";
            //oUsuario.contra = "12345678";

            //Console.WriteLine ( "El usuario es " + oUsuario.nombreUsuario + " su contraseña " + oUsuario.contra );

            #endregion
            #region clases3
            //Persona oPersona = new Persona ( );
            //Persona oPersona=new Persona ( "Felipe", "Gonzalez", "Suarez", 23, 2000 );
            //Persona oPersona2=new Persona ( );
            //oPersona2.nombre = "Jorge";
            //oPersona2.apPaterno = "Fernandez";
            //oPersona2.apMaterno = "Cocolizo";
            //oPersona2.edad = 30;
            //oPersona2.sueldo = 1000;
            //Console.WriteLine ( "Edad " + oPersona.edad );
            //Console.WriteLine ( "Edad segundo objeto " + oPersona2.edad );
            #endregion
            #region clases4
            //Persona oPersona = new Persona ( );
            //oPersona.setSueldo ( 5000 );
            //Console.WriteLine ( oPersona.getSueldo ( ) );
            #endregion
            #region clases5
            Persona oPersona = new Persona ( );
            oPersona.setNombre ( "Rodrigo" );
            oPersona.setApPaterno ( "Gonazalez" );
            oPersona.setApMaterno ( "Padilla" );
            oPersona.setEdad ( 10 );
            oPersona.setSueldo ( -1700 );
            Console.WriteLine ( oPersona.getEdad ( ) );
            Console.WriteLine ( oPersona.getSueldo ( ) );
            #endregion
            Console.ReadLine ( );
        }
    }
}
