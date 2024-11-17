using System;


    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("La suma de los primeros 100 números naturales es: " + suma);
            Console.ReadKey();
        }
    }
