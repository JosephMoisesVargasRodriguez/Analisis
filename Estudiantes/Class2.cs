using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public List<double> Calificaciones { get; set; }

        public Estudiante(string nombre, List<double> calificaciones)
        {
            Nombre = nombre;
            Calificaciones = calificaciones;
        }
    }

}
