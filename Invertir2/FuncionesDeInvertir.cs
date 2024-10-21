using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertir2
{
      class ArregloDeFunciones
      {
            // Función para invertir el arreglo
            public static int[] InvertirArreglo(int[] arreglo)
            {
                int[] invertido = new int[arreglo.Length];
                int j = arreglo.Length - 1;

                for (int i = 0; i < arreglo.Length; i++)
                {
                    invertido[j] = arreglo[i];
                    j--;
                }

                return invertido;
            }

            // Función para contar los impares en el arreglo invertido
            public static void ContarImpares(int[] arregloInvertido)
            {
                int conteoImpares = 0;

                Console.WriteLine("\n-----------------------------------------");
                Console.WriteLine("|Números impares en el arreglo invertido|");
                Console.WriteLine("-----------------------------------------");

                for (int i = 0; i < arregloInvertido.Length; i++)
                {
                    if (arregloInvertido[i] % 2 != 0)
                    {
                        Console.Write(arregloInvertido[i] + " ");
                        conteoImpares++;
                    }
                }

                Console.WriteLine("\nCantidad de números impares:");
                Console.WriteLine($"{conteoImpares}");
                Console.WriteLine("----------------------------------------");
            }

            // Función para mostrar el arreglo
            public static void MostrarArreglo(int[] arreglo)
            {
                foreach (int num in arreglo)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
      }
}
