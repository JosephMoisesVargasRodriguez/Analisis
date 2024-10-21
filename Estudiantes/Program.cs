using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes
{
    class Program
    {
        static void Main()
        {
            GestorCalificaciones gestor = new GestorCalificaciones();
            string continuar;

            do
            {
                Console.Write("Ingrese el nombre del estudiante: ");
                string nombre = Console.ReadLine();

                List<double> calificaciones = new List<double>();
                Console.WriteLine("Ingrese las calificaciones (ingrese -1 para terminar):");

                while (true)
                {
                    double calificacion = double.Parse(Console.ReadLine());
                    if (calificacion == -1)
                        break;
                    calificaciones.Add(calificacion);
                }

                gestor.AgregarEstudiante(nombre, calificaciones);

                Console.Write("¿Desea agregar otro estudiante? (s/n): ");
                continuar = Console.ReadLine().ToLower();

            } while (continuar == "s");

            gestor.MostrarEstudiantes();

            var (estudianteAlto, promedioAlto, estudianteBajo, promedioBajo) = gestor.DeterminarAltoBajoEstudiante();
            Console.WriteLine($"El estudiante con el promedio más alto es: {estudianteAlto} con un promedio de {promedioAlto:F2}");
            Console.WriteLine($"El estudiante con el promedio más bajo es: {estudianteBajo} con un promedio de {promedioBajo:F2}");
            Console.ReadKey();
        }
    }

}
