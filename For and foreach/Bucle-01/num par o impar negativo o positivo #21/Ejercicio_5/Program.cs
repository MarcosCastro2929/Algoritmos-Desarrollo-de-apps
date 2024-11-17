using System;

class Program
{
    static void Main(string[] args)
    {


        int cant;
        int num;
        int positivos = 0;
        int negativos = 0;
        int pares = 0;
        int impares = 0;

        Console.Write("Ingrese la cantidad de números enteros que se van a evaluar: ");
        cant = Convert.ToInt32(Console.ReadLine());


        for (int i = 0; i < cant; i++)
        {
            Console.Write("Ingrese un numero entero: ");
            num = Convert.ToInt32(Console.ReadLine());


            if (num >= 0)
            {
                positivos = positivos + 1;
            }

            else { negativos = negativos + 1; }


            if (num % 2 == 0)
            {
                pares = pares + 1;
            }

            else { impares = impares + 1; }

        }

        Console.WriteLine("La cantidad de números positivos es: " + positivos);
        Console.WriteLine("La cantidad de números negativos es: " + negativos);
        Console.WriteLine("La cantidad de números pares es: " + pares);
        Console.Write("La cantidad de números impares es: " + impares);







    }
}
