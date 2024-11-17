using System;

class Program
{
    static void Main(string[] args)
    {


        double nota1;
        double nota2;
        double nota3;
        double nota4;
        double promedio;



        Console.Write("Ingrese la primera nota: ");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la segunda nota: ");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la tercera nota: ");
        nota3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la cuarta nota: ");
        nota4 = Convert.ToInt32(Console.ReadLine());

        promedio = nota1 + nota2 + nota3 + nota4;
        promedio = promedio / 4;

        if (promedio >= 70)
        {
            Console.Write("el estudiante aprobó con una nota de:" + promedio);
        }

        else
        {
            Console.Write("el estudiante reprobó con una nota de:" + promedio);
        }





      
    }
}
