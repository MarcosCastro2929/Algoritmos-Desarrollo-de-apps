using System;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("inserta el primer numero para sumar: ");
            int SumaNum1 = int.Parse(Console.ReadLine());

            Console.Write("inserta el segundo numero para sumar: ");
            int SumaNUm2 = int.Parse(Console.ReadLine());

            Console.WriteLine(SumadDosNumeros(SumaNum1, SumaNUm2));


            Console.Write("inserta el primer numero para multiplicar: ");
            int multiNum1 = int.Parse(Console.ReadLine());

            Console.Write("inserta el segundo numero para sumar: ");
            int multiNUm2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Multiplicacion(multiNUm2, SumaNUm2));


            Console.Write("inserta el primer numero para saber si es par o no: ");
            int NumPares = int.Parse(Console.ReadLine());

            Console.WriteLine(NumerosPares(NumPares));

            Console.Write("inserta el primer numero para convertir la cantidad: ");
            double Cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine(Convertir(Cantidad));

        }

        static int SumadDosNumeros(int num1, int num2)
        {

            return num2 + num1;

        }

        static int Multiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }

        static int NumerosPares(int num1)
        {
            if (num1 % 2 == 0)
            {
                Console.WriteLine("Es un numero par");
            }

            else
            {
                Console.WriteLine("el numero no es par");
            }



            return num1;
        }

        static double Convertir(double CantidadDolares)
        {

            return CantidadDolares * 60;
        }
    }
}