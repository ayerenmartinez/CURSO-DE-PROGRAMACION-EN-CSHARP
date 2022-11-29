using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTRUCTURA_CONDICIONAL.EJERCICIOS_APRENDIZAJE
{
    internal class Ejercicio1
    {
        public static void determinarSueldoMayor()
        {
            //Un hombre desea saber si su sueldo es mayor al sueldo mínimo, el programa le pedirá al
            //usuario su sueldo actual y el sueldo mínimo. Si el sueldo es mayor al mínimo se debe
            //mostrar un mensaje por pantalla indicándolo

            #region ENTRADAS
            double sueldo = 0;
            const double sueldoMinimo = 1050;
            bool mayor = false;

            Console.WriteLine("Ingrese su Sueldo: ");
            sueldo = double.Parse(Console.ReadLine());
            #endregion FIN-ENTRADAS
            #region PROCESO

            if (sueldo>sueldoMinimo){
                mayor = true;
            }
          

            #endregion FIN-PROCESO
            #region SALIDA

            if (mayor) {
                Console.WriteLine("El Sueldo es Mayor que el Sueldo Minimo");
            }
           

            Console.ReadKey();       
            #endregion FIN-SALID

        }
    }
}
