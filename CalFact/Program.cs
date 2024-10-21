using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalFact
{
    class Program
    {
        static void Main()
        {
            const int tamanioArreglo = 100; // Tamaño maximo del arreglo
            CalculadoraFactorial calculadora = new CalculadoraFactorial(tamanioArreglo);
            char continuar;
            
            do
            {
                Console.Write("Ingrese un numero positivo o cero: ");
                int numero = int.Parse(Console.ReadLine());

                calculadora.AgregarNumero(numero);

                // Pregunta al usuario si desea continuar
                Console.Write("¿Desea ingresar otro numero? (s/n): ");
                continuar = Console.ReadKey().KeyChar;
                Console.WriteLine(); // Salto de linea

            } while (continuar == 's' || continuar == 'S');

            // Muestra los resultados
            calculadora.MostrarResultados();
            Console.ReadKey();
        }
    }
}
