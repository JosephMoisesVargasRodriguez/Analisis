using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventas
{
    public class GestorVentas
    {
        private double[] ventas;

        public GestorVentas(int dias)
        {
            ventas = new double[dias];
        }

        public void IngresarVentas()
        {
            for (int i = 0; i < ventas.Length; i++)
            {
                Console.Write($"Ingrese las ventas del día {i + 1}: ");
                ventas[i] = double.Parse(Console.ReadLine());
            }
        }

        public double CalcularTotal()
        {
            double total = 0;
            for (int i = 0; i < ventas.Length; i++)
            {
                total += ventas[i];
            }
            return total;
        }

        public int EncontrarDiaConVentaMaxima()
        {
            double ventaMaxima = ventas[0];
            int diaMaximo = 0;

            for (int i = 1; i < ventas.Length; i++)
            {
                if (ventas[i] > ventaMaxima)
                {
                    ventaMaxima = ventas[i];
                    diaMaximo = i;
                }
            }

            return diaMaximo;
        }

        public double[] ObtenerVentas()
        {
            return ventas;
        }
    }

}
