using System;


    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            double suma = 0;

            for (int i = 1; i <= n; i++)
            {
               suma = suma + i;
            }

            double promedio = suma / n;

            Console.WriteLine("El promedio de los primeros " + n + " numeros naturales es: " + promedio);

            Console.ReadKey();
        }
    }
