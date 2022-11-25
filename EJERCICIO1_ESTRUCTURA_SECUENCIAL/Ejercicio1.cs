using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO1_ESTRUCTURA_SECUENCIAL
{
    public class Ejercicio1
    {
        public static void calcularAreaPerimetro()
        {
            //.Conocido el número en matemática PI π, pedir al usuario que ingrese el valor del radio deuna circunferencia y calcular y mostrar por pantalla el área y perímetro.Recuerde que para
            //calcular el área y el perímetro se utilizan las siguientes fórmulas: 
            //area = PI* radio2
            //perimetro = 2 * PI* radio
            
            #region DECLARACION DE VARIABLES - ENTRADA
            const double pi = 3.14;
            double radio = 0, area = 0, perimetro = 0;

            Console.WriteLine("Por favor Ingrese el Radio de la Circunferencia: ");
            radio = double.Parse(Console.ReadLine());
            #endregion

            #region PROCESO
            //CALCULAR EL AREA DE LA CIRCUNFERENCIA
                //area = pi * radio * radio;
                //area = pi * Math.Pow(radio,2);
            area = Math.PI * Math.Pow(radio, 2);
            perimetro = 2 * Math.PI * radio;
            #endregion FIN PROCESO

            #region SALIDA - MOSTRAR RESULTADOS
            Console.WriteLine("El Área de la Cirfurencia es: " + area);
            Console.WriteLine("El Perimetro de la Circunferencia es: " + perimetro);
            Console.ReadKey(); //termino del programa en c#
            #endregion
        }

    }
}
