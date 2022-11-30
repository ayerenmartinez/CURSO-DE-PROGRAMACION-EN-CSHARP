using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTRUCTURA_CONDICIONAL.EJERCICIOS_APRENDIZAJE
{
    internal class Ejercicio3
    {
        public static void determinarParImpar()
        {
            //Realizar un programa que pida un número y determine si ese número es par o impar.
            //Mostrar en pantalla un mensaje que indique si el número es par o impar. (para que un
            //número sea par, se debe dividir entre dos y su resto debe ser igual a 0). Nota: investigar
            //la función mod de C#

            #region ENTRADA
            int numero = 0;
            bool par = false;
            Console.WriteLine("Por favor ingrese un Número: ");
            numero = int.Parse(Console.ReadLine());
            #endregion FIN-ENTRADA

            #region PROCESO
            if (numero%2==0)
            {
                par = true;
            }
            else
            {
                par = false;
            }
            #endregion FIN-PROCESO

            #region SALIDA
            if (par)
            {
                Console.WriteLine("EL NÚMERO ES PAR");
            }
            else
            {
                Console.WriteLine("EL NÚMERO ES IMPAR");
            }
            Console.ReadKey();
            #endregion FIN-SALIDA

        }

    }
}
