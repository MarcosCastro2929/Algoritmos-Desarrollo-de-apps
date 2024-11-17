using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos estudiantes vas a ingresar");

            int estudiantesIngresar = int.Parse(Console.ReadLine());

            int[] calificaciones = new int[estudiantesIngresar];
            string[] nombre = new string[estudiantesIngresar];
            Console.WriteLine();

            for (int i = 0; i < estudiantesIngresar; i++)
            {
                Console.Write("Inserte el nombre del estudiante: ");
                nombre[i] = Console.ReadLine();

                Console.Write("Inserte la calificacion del estudiante: ");
                calificaciones[i] = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            Estudiante(nombre, calificaciones);

        }

        static void Estudiante(string[] estudiante, int[] calificaciones)
        {
            foreach (string estudianteName in estudiante)
            {
                Console.Write($"El nombre del estudiante es: {estudianteName}");
                Console.WriteLine();
            }

            foreach (int calificacionesE in calificaciones)
            {
                Console.Write($"La calificacion del estudiante es: {calificacionesE}");
                Console.WriteLine();
            }
        }
    }
}