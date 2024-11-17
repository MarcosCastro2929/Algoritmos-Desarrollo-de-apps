using System;

class Program
{
    static void Main(string[] args)
    {





        double num1, num2, num3, mayor, central, menor;


        Console.Write("Ingrese un primer número entero: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese un segundo número entero: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese un tercer número entero: ");
        num3 = Convert.ToInt32(Console.ReadLine());


        if (num1 > num2 && num1 > num3)
        {
            mayor = num1;
            if (num2 > num3)
            {
                central = num2;
                menor = num3;
            }
            else
            {
                central = num3;
                menor = num2;
            }
        }
        else if (num2 > num1 && num2 > num3)
        {
            mayor = num2;
            if (num1 > num3)
            {
                central = num1;
                menor = num3;
            }
            else
            {
                central = num3;
                menor = num1;
            }
        }
        else
        {
            mayor = num3;
            if (num1 > num2)
            {
                central = num1;
                menor = num2;
            }
            else
            {
                central = num2;
                menor = num1;
            }
        }

        Console.WriteLine("El número mayor es: " + mayor);
        Console.WriteLine("El número central es: " + central);
        Console.WriteLine("El número menor es: " + menor);









    }
}
