using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueva_tecnica_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char[,] hotel = new char[5, 10];


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    hotel[i, j] = 'L';
                }
            }

            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Gestión de Habitaciones - Hotel La Paja");
                Console.WriteLine("1. Mostrar mapa de habitaciones");
                Console.WriteLine("2. Ocupar una habitación");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");


                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MostrarMapa(hotel);
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Write("\nIngrese el número de piso (1-5): ");
                        int piso = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el número de habitación (1-10): ");
                        int habitacion = int.Parse(Console.ReadLine());

                        string resultado = OcuparHabitacion(hotel, piso, habitacion);
                        Console.WriteLine("\n" + resultado);
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Saliendo del sistema...");
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void MostrarMapa(char[,] hotel)
        {
            Console.WriteLine("\nMapa de habitaciones:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Piso {i + 1}: ");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(hotel[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static string OcuparHabitacion(char[,] hotel, int piso, int habitacion)
        {
            if (piso < 1 || piso > 5 || habitacion < 1 || habitacion > 10)
            {
                return "Número de piso o habitación fuera de rango.";
            }

            if (hotel[piso - 1, habitacion - 1] == 'L')
            {
                hotel[piso - 1, habitacion - 1] = 'X';
                return $"Habitación {habitacion} en el piso {piso} ahora está ocupada.";
            }
            else
            {
                return $"Habitación {habitacion} en el piso {piso} ya está ocupada.";
            }

        }
    }
}





