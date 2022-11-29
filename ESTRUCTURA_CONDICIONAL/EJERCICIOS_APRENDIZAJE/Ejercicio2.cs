using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTRUCTURA_CONDICIONAL.EJERCICIOS_APRENDIZAJE
{
    internal class Ejercicio2
    {
        public static void ingresarSN()
        {
            //Realiza un programa que sólo permita introducir los caracteres ‘S’ y ‘N’. Si el usuario
            //ingresa alguno de esos dos caracteres se deberá de imprimir un mensaje por pantalla que
            //diga “CORRECTO”, en caso contrario, se deberá imprimir “INCORRECTO”. 

            #region ENTRADA
            char letra ='a';
            bool igual = false;
            Console.WriteLine("Ingrese un Caracter S o N");
            letra = char.Parse(Console.ReadLine());
            #endregion FIN-ENTRADA

            #region PROCESO

            if (letra.Equals('S') || letra.Equals('N'))
            {
                igual = true;
            }
            else
            {
                igual = false;
            }

            #endregion FIN-PROCESO

            #region SALIDA
            if (igual)
            {
                Console.WriteLine("CORRECTO");
            }
            else
            {
                Console.WriteLine("INCORRECTO");
            }
            Console.ReadKey();
            #endregion FIN-SALIDA

        }
    }
}
