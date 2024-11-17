using System;

class Program
{
    static void Main(string[] args)
    {


        int num;


        Console.Write("Ingrese un numero entero: ");
        num = Convert.ToInt32(Console.ReadLine());

        

        if (num >= 0)
        {
            Console.WriteLine("¡El numero ingresado es: " + num);
            Console.WriteLine("¡El numero es positivo!");
        }

        else
        {
            Console.WriteLine("¡El numero ingresado es negativo!");
        }





      
    }
}
