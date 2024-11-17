using System;

class Program
{
    static void Main(string[] args)
    {
        string materia;
        string nombre;
        double nota1;
        double nota2;
        double nota3;
        double nota4;
        double promedio;
        double examen_completivo;
        double nota_completiva;
        double examen_extraordinario;
        double nota_extraordinario;

        Console.Write("Ingrese su nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese la materia: ");
        materia = Convert.ToString(Console.ReadLine());

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
            Console.WriteLine("Nombre del estudiante: " + nombre);
            Console.WriteLine($"El estudiante aprobó en la materia {materia} con la siguiente nota: " + promedio);
        } else 
        {
            Console.WriteLine("El estudiante reprobó ");

            Console.Write("Ingrese la nota del examen completivo: ");
            examen_completivo = Convert.ToInt32(Console.ReadLine());

            nota_completiva = promedio * 0.50 + examen_completivo * 0.50;

            if (nota_completiva >= 70)
            {
                Console.WriteLine("Nombre del estudiante: " + nombre);
                Console.WriteLine($"El estudiante aprobó el completivo de la materia {materia} con la siguiente nota: " + nota_completiva);
            }

            else
            {
                Console.Write("El estudiante reprobó ");

                Console.Write("Ingrese la nota del examen extraordinario: ");
                examen_extraordinario = Convert.ToInt32(Console.ReadLine());

                nota_extraordinario = promedio * 0.30 + examen_extraordinario * 0.70;

                if (nota_extraordinario >= 70)
                {
                    Console.WriteLine("Nombre del estudiante: " + nombre);
                    Console.WriteLine($"El estudiante aprobó el extraordinario de la materia {materia} con la siguiente nota: " + nota_extraordinario);
                }

                else
                {
                    Console.WriteLine("Nombre del estudiante: " + nombre);
                    Console.Write($"El estudiante reprobó la materia {materia}");

                }
            }

            
        }


     






    }
}
