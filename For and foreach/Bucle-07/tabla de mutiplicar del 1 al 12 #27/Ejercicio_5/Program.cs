using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {


        double resultado;
        double num;
        

        Console.Write("Ingrese un número: ");
        num = Convert.ToDouble(Console.ReadLine());


        for (int i = 1; i <= 12; i++)
        {


            resultado = num * i;

            Console.WriteLine($"{num} * {i} = {resultado}");


        }








    }
}
