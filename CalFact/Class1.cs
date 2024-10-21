using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalFact
{
    using System;

    public class CalculadoraFactorial
    {
        private int[] arregloNumeros;
        private long[] arregloFactoriales;
        private int contador;

        public CalculadoraFactorial(int tamanio)
        {
            arregloNumeros = new int[tamanio];
            arregloFactoriales = new long[tamanio];
            contador = 0;
        }

        public void AgregarNumero(int numero)
        {
            if (numero >= 0)
            {
                arregloNumeros[contador] = numero;
                arregloFactoriales[contador] = CalcularFactorial(numero);
                contador++;
            }
            else
            {
                Console.WriteLine("El número debe ser positivo o cero.");
            }
        }

        private long CalcularFactorial(int numero)
        {
            if (numero == 0) return 1; // El factorial de 0 es 1
            long factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public void MostrarResultados()
        {
            Console.WriteLine("\nArreglo de números ingresados:");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(arregloNumeros[i]);
            }

            Console.WriteLine("\nArreglo de factoriales:");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"Factorial de {arregloNumeros[i]}: {arregloFactoriales[i]}");
            }
        }
    }

}
