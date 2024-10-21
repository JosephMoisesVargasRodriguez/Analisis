using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventas
{
    class Program
    {
        static void Main()
        {
            const int diasDelMes = 30; // Suponiendo un mes con 30 días
            GestorVentas gestor = new GestorVentas(diasDelMes);

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("|           Ingreso de Ventas Diarias           |");
            Console.WriteLine(new string('-', 50));

            gestor.IngresarVentas();

            double totalVendido = gestor.CalcularTotal();
            Console.Clear();
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("|               Resumen de Ventas del Mes       |");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("| Total vendido en el mes: {0,20:C} |", totalVendido);
            Console.WriteLine(new string('-', 50));

            int diaMaximo = gestor.EncontrarDiaConVentaMaxima();
            Console.WriteLine("| El día con la venta más alta es el día {0,2} |", diaMaximo + 1);
            Console.WriteLine("| Venta más alta: {0,25:C} |", gestor.ObtenerVentas()[diaMaximo]);
            Console.WriteLine(new string('-', 50));

            // Opcional: Mostrar las ventas diarias en formato de tabla
            MostrarVentas(gestor.ObtenerVentas());
        }

        static void MostrarVentas(double[] ventas)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("|                 Ventas Diarias                 |");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("| Día |        Venta        |");
            Console.WriteLine(new string('-', 50));

            for (int i = 0; i < ventas.Length; i++)
            {
                Console.WriteLine($"| {i + 1,2} | {ventas[i],20:C} |");
            }

            Console.WriteLine(new string('-', 50));
            Console.ReadKey();
        }
    }

}
