using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertir2
{
    class Program
    {
        static void Main()
        {
            // Solicitar al usuario la longitud del arreglo
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|  ¿Cuántos números deseas ingresar?   |");
            Console.WriteLine("----------------------------------------");

            int n = int.Parse(Console.ReadLine());

            // Crear el arreglo
            int[] arreglo = new int[n];

            // Solicitar los números al usuario
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("| Ingresa los números:                 |");
            Console.WriteLine("----------------------------------------");

            for (int i = 0; i < n; i++)
            {
                int numero;
                do
                {
                    Console.Write($"| Número {i + 1}: ");
                    numero = int.Parse(Console.ReadLine());

                    // Verificar si el número es negativo
                    if (numero < 0)
                    {
                        Console.WriteLine("| Error: El numero es negativo. Inténtalo de nuevo.");
                    }

                } while (numero < 0);  // Repetir si el número es negativo

                arreglo[i] = numero;
            }

            // Mostrar el arreglo original
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("| Arreglo original:                    |");
            Console.WriteLine("----------------------------------------");

            ArregloDeFunciones.MostrarArreglo(arreglo);

            // Invertir el arreglo
            int[] arregloInvertido = ArregloDeFunciones.InvertirArreglo(arreglo);

            // Mostrar el arreglo invertido
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("| Arreglo invertido:                   |");
            Console.WriteLine("----------------------------------------");

            ArregloDeFunciones.MostrarArreglo(arregloInvertido);

            // Contar e imprimir los impares en el arreglo invertido
            ArregloDeFunciones.ContarImpares(arregloInvertido);

            // Esperar que el usuario presione enter para finalizar
            Console.WriteLine("Presiona enter para finalizar...");
            Console.ReadKey();
        }
    }
}
