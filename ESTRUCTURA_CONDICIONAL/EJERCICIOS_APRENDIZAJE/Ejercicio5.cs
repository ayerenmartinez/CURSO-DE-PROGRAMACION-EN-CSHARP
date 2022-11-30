using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTRUCTURA_CONDICIONAL.EJERCICIOS_APRENDIZAJE
{
    internal class Ejercicio5
    {
        public static void pedirFrase()
        {
            //Realizar un programa que pida una frase o palabra y si la frase o palabra es de 4
            //caracteres de largo, el programa le concatenara un signo de exclamación al final, y si no
            //es de 4 caracteres el programa le concatenara un signo de interrogación al final.El
            //programa mostrará después la frase final.Nota: investigar la función Longitud() y
            //Concatenar() de PseInt.

            #region ENTRADA
            string frase ="";
            string nuevaFrase = "";
            Console.WriteLine("Porfavor Ingrese una Frase o Palabra: ");
            frase = Console.ReadLine();
            #endregion FIN-ENTRADA

            #region PROCESO
            if (frase.Length.Equals(4))
            {
                nuevaFrase = String.Concat(frase,"!");
            }
            else
            {
                nuevaFrase = frase;
            }
            #endregion FIN-PROCESO

            #region SALIDA
            Console.WriteLine("La Frase Final es: {0} ", nuevaFrase);
            Console.ReadKey();
            #endregion FIN-SALIDA


        }
    }
}
