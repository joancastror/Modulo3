using System;
using System.Collections.Generic;
using System.Linq;

namespace Universidad
{
    public class Alumno
    {
        // Propiedades de la clase Alumno
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Carrera { get; set; }
        public List<int> Calificaciones { get; set; }

        // Constructor para inicializar el alumno con nombre, matrícula, carrera y calificaciones
        public Alumno(string nombre, string matricula, string carrera, List<int> calificaciones)
        {
            Nombre = nombre;
            Matricula = matricula;
            Carrera = carrera;
            Calificaciones = calificaciones;
        }

        // Método para calcular el promedio de las calificaciones
        public double CalcularPromedio()
        {
            if (Calificaciones.Count == 0)
            {
                return 0.0;
            }

            return Calificaciones.Average();
        }

        // Método para mostrar la información del alumno
        public void MostrarInformacion()
        {
            double promedio = CalcularPromedio();
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Promedio: {promedio:F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista de calificaciones
            List<int> calificaciones = new List<int> { 85, 90, 78, 92, 88 };

            // Crear una instancia de Alumno
            Alumno alumno = new Alumno("Juan Pérez", "A123456", "Ingeniería en Sistemas", calificaciones);

            // Mostrar la información del alumno
            alumno.MostrarInformacion();

            // Crear otra instancia de Alumno
            List<int> calificaciones2 = new List<int> { 80, 75, 90, 85, 95 };
            Alumno alumno2 = new Alumno("María López", "B789012", "Administración de Empresas", calificaciones2);

            // Mostrar la información del segundo alumno
            alumno2.MostrarInformacion();
        }
    }
}
