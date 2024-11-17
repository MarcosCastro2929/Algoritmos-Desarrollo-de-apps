using System;

class Program
{
    static void Main(string[] args)
    {


        double num1;
        double num2;
        double num3;


        Console.Write("Ingrese un primer número entero: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese un segundo número entero: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese un tercer número entero: ");
        num3 = Convert.ToInt32(Console.ReadLine());



        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine("El número mayor es: " + num1);
        }

        else if (num1 < num2 && num2 > num3)
        {
            Console.WriteLine("El número mayor es: " + num2);
        }

        else 
        {
            Console.WriteLine("El número mayor es: " + num3);
        }

        








    }
}
