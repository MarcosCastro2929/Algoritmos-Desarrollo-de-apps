using System;

namespace PatrónTriangular
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas;

            Console.Write("Ingrese el número de filas para el patrón triangular: ");
            filas = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 1; i <= filas; i++)
            {


                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }



                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}