using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de números a sumar: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int suma = 0;




        for (int i = 0; i < n; i++)
        {
            Console.Write("Ingrese el número " + (i + 1) );
            int numero = Convert.ToInt32(Console.ReadLine());
            suma = suma + numero; 
        }

       


        if (suma >= 100)
        {
            Console.WriteLine("La sumatoria es mayor o igual a 100.");
            
        }



        else
        {
            Console.WriteLine("La sumatoria es menor a 100.");
        }

    }
}