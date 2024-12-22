using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_tecnica_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (salir == false)
            {

                Estudiante[] estudiantes = new Estudiante[2];
                Asignatura[] asignaturas = new Asignatura[3];

                Console.WriteLine("         Menu de opciones       ");
                Console.WriteLine("");
                Console.WriteLine();

                Console.WriteLine("[0]Agregar estudiante");
                Console.WriteLine("[1]Mostrar registros");


                int menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 0:
                        for (int i = 0; i < estudiantes.Length; i++)
                        {
                            estudiantes[i] = new Estudiante();
                            Console.Write($"Inserta el nombre del estudiante {i + 1}: ");
                            estudiantes[i].nombre = Console.ReadLine();

                            Console.Write($"Inserta la edad del estudiante {i + 1}: ");
                            estudiantes[i].edad = int.Parse(Console.ReadLine());

                            Console.WriteLine();
                        }

                        asignaturas = RegistroAcademico.AgregarAsignatura();
                        break;

                    case 1:

                        RegistroAcademico.MostrarRegistro(estudiantes, asignaturas);
                        break;







                }

                Console.WriteLine("Deseas volver al menu principal (si / no)");
                string rp = Console.ReadLine().ToLower();

                if (rp == "si")
                {
                    salir = false;
                }
                else
                {
                    Console.WriteLine("se ah cerrado el programa");
                    salir = true;


                }
            }



        }
    }

    class Estudiante
    {
        public string nombre { get; set; }
        public int edad { get; set; }
    }

    class Asignatura
    {
        public string Nombre { get; set; }
        public double nota1 { get; set; }
        public double nota2 { get; set; }
        public double nota3 { get; set; }
        public double nota4 { get; set; }
        public double promedio { get; set; }
    }

    class RegistroAcademico
    {
        public static Asignatura[] AgregarAsignatura()
        {
            Asignatura[] asignaturas = new Asignatura[3];

            for (int i = 0; i < asignaturas.Length; i++)
            {
                asignaturas[i] = new Asignatura();
                Console.WriteLine($"Inserta el nombre de la asignatura {i + 1}:");
                asignaturas[i].Nombre = Console.ReadLine();

                Console.Write("Inserte la primera calificación: ");
                asignaturas[i].nota1 = double.Parse(Console.ReadLine());

                Console.Write("Inserte la segunda calificación: ");
                asignaturas[i].nota2 = double.Parse(Console.ReadLine());

                Console.Write("Inserte la tercera calificación: ");
                asignaturas[i].nota3 = double.Parse(Console.ReadLine());

                Console.Write("Inserte la cuarta calificación: ");
                asignaturas[i].nota4 = double.Parse(Console.ReadLine());

                asignaturas[i].promedio = CalcularPromedio(
                    asignaturas[i].nota1,
                    asignaturas[i].nota2,
                    asignaturas[i].nota3,
                    asignaturas[i].nota4
                );
            }

            return asignaturas;
        }

        public static double CalcularPromedio(double nota1, double nota2, double nota3, double nota4)
        {
            return (nota1 + nota2 + nota3 + nota4) / 4;
        }

        public static void MostrarRegistro(Estudiante[] estudiantes, Asignatura[] asignaturas)
        {
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine($"Información del Estudiante {i + 1}");
                Console.WriteLine("Nombre: " + estudiantes[i].nombre);
                Console.WriteLine("Edad: " + estudiantes[i].edad);

                Console.WriteLine("Calificaciones:");
                for (int j = 0; j < asignaturas.Length; j++)
                {
                    Console.WriteLine($"{asignaturas[j].Nombre}: Promedio = {asignaturas[j].promedio}");
                }
            }
        }
    }
}


