using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el sueldo del empleado:");
        double sueldo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el número de hijos del empleado:");
        int numeroHijos = Convert.ToInt32(Console.ReadLine());

        double incentivo = 0;
        if (numeroHijos > 0)
        {
            incentivo = numeroHijos * 500;
        }

        Console.WriteLine("Sueldo: " + sueldo);
        Console.WriteLine("Número de hijos: " + numeroHijos);

        if (incentivo > 0)
        {
            Console.WriteLine("Incentivo: " + incentivo);
            Console.WriteLine("Sueldo total: " + (sueldo + incentivo));
        }
        else
        {
            Console.WriteLine("Incentivo: N/A");
        }
    }
}