using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes
{
    public class GestorCalificaciones
    {
        private List<Estudiante> Estudiantes;

        public GestorCalificaciones()
        {
            Estudiantes = new List<Estudiante>();
        }

        public void AgregarEstudiante(string nombre, List<double> calificaciones)
        {
            Estudiante nuevoEstudiante = new Estudiante(nombre, calificaciones);
            Estudiantes.Add(nuevoEstudiante);
        }

        public double CalcularPromedio(List<double> calificaciones)
        {
            if (calificaciones.Count == 0)
                return 0;

            double suma = 0;
            foreach (var nota in calificaciones)
            {
                suma += nota;
            }
            return suma / calificaciones.Count;
        }

        public (string estudianteAlto, double promedioAlto, string estudianteBajo, double promedioBajo) DeterminarAltoBajoEstudiante()
        {
            string estudianteAlto = "";
            double promedioAlto = double.MinValue;

            string estudianteBajo = "";
            double promedioBajo = double.MaxValue;

            foreach (var estudiante in Estudiantes)
            {
                double promedio = CalcularPromedio(estudiante.Calificaciones);

                if (promedio > promedioAlto)
                {
                    promedioAlto = promedio;
                    estudianteAlto = estudiante.Nombre;
                }

                if (promedio < promedioBajo)
                {
                    promedioBajo = promedio;
                    estudianteBajo = estudiante.Nombre;
                }
            }

            return (estudianteAlto, promedioAlto, estudianteBajo, promedioBajo);
        }

        public void MostrarEstudiantes()
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("|                 Estudiantes y Calificaciones                 |");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("| Nombre                | Promedio                |");
            Console.WriteLine(new string('-', 50));

            foreach (var estudiante in Estudiantes)
            {
                double promedio = CalcularPromedio(estudiante.Calificaciones);
                Console.WriteLine($"| {estudiante.Nombre,-20} | {promedio,-20:F2} |");
            }

            Console.WriteLine(new string('-', 50));
        }
    }

}
