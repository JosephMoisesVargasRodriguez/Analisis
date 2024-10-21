using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion
{
    internal class Facturacion
    {
        public static void Factura(string[] nombre, int[] cantidad, float[] precio)
        {
            float[] total = new float[nombre.Length];

            for (int i = 0; i < nombre.Length; i++)
            {
                total[i] = precio[i] * cantidad[i];
            }

            float neto = 0;
            for (int i = 0; i < total.Length; i++)
            {
                neto += total[i];
            }
            // LONGITUD DE BARRA INFERIOR
            int lonBarra = 0;
            // Calculando el nombre mas largo   
            int max = nombre[0].Length;

            for (int i = 0; i < nombre.Length; i++)
            {
                int aux = nombre[i].Length;

                if (aux > max)
                {
                    max = aux;
                }
            }
            Console.Write(" ");
            // Barra  superior
            for (int i = 0; i < max; i++)
            {
                Console.Write("_");
                lonBarra++;
            }
            Console.Write("___");

            // Precio mas largo
            int maxP = precio[0].ToString().Length;

            for (int i = 0; i < precio.Length; i++)
            {
                int aux = precio[i].ToString().Length;

                if (aux > maxP)
                {
                    maxP = aux;
                }
            }
            // Barra  superior
            for (int i = 0; i < maxP; i++)
            {
                Console.Write("_");
                lonBarra++;
            }
            Console.Write("___");
            // Cantidad mas largo
            int maxC = cantidad[0].ToString().Length;

            for (int i = 0; i < precio.Length; i++)
            {
                int aux = cantidad[i].ToString().Length;

                if (aux > maxC)
                {
                    maxC = aux;
                }
            }
            // Barra  superior
            for (int i = 0; i < maxC; i++)
            {
                Console.Write("_");
                lonBarra++;
            }
            Console.Write("___");
            // Total mas largo
            int maxT = total[0].ToString().Length;

            for (int i = 0; i < precio.Length; i++)
            {
                int aux = total[i].ToString().Length;

                if (aux > maxT)
                {
                    maxT = aux;
                }
            }
            // Barra  superior
            for (int i = 0; i < maxT; i++)
            {
                Console.Write("_");
                lonBarra++;
            }
            // Asignando longitud total de barra inferior
            lonBarra += 11;

            Console.WriteLine("| ");
            // Cuerpo medio nombre
            double me = max / 2;
            int medio = (int)Math.Round(me);

            for (int i = 0; i <= medio; i++)
            {
                Console.WriteLine(" ");
                if (i >= medio)
                {
                    Console.Write("Nombre");
                }
            }
            // Cuerpo medio precio
            double meP = max / 2;
            int medioP = (int)Math.Round(meP);

            for (int i = 0; i <= medioP; i++)
            {
                Console.WriteLine(" ");
                if (i >= medioP)
                {
                    Console.Write("Precio");
                }
            }
            // Cuerpo medio cantidad
            double meC = max / 2;
            int medioC = (int)Math.Round(meC);

            for (int i = 0; i <= medioC; i++)
            {
                Console.WriteLine(" ");
                if (i >= medioC)
                {
                    Console.Write("Cantidad");
                }
            }
            // Cuerpo medio total
            double meT = max / 2;
            int medioT = (int)Math.Round(meT);

            for (int i = 0; i <= medioT; i++)
            {
                Console.WriteLine(" ");
                if (i >= medioT)
                {
                    Console.Write("Total");
                }
            }
            // Cuerpo de la factura
            for (int i = 0; i < total.Length; i++)
            {
                Console.WriteLine($"| {nombre[i]}   {precio[i]}   {cantidad[i]}   {total[i]} |");
            }
            int MAXIMO = max + maxC + maxP + maxT;
            Console.WriteLine("| Neto");
            for (int i = 0; i < MAXIMO; i++)
            {
                Console.Write(" ");
            }

            Console.Write($"{neto} |\n");
            // Barra inferior
            for (int i = 0; i < lonBarra; i++)
            {
                Console.Write("_");
            }
        }
    }
}