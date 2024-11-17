using System;

class Program
{
    static void Main(string[] args)
    {
        double sueldoBruto, afp, sfs, isr, sueldoNeto;
        double afpRate = 0.0287; 
        double sfsRate = 0.0304; 
        double exentoISR = 499884.00;
        double tramo1 = 749822.00;
        double tramo2 = 1041224.00;

       
        Console.Write("Ingrese el sueldo mensual del empleado: ");
        sueldoBruto = Convert.ToDouble(Console.ReadLine());

        
        afp = sueldoBruto * afpRate;
        sfs = sueldoBruto * sfsRate;

        
        double sueldoAnual = sueldoBruto * 12;

        
        isr = 0;

        
        if (sueldoAnual > exentoISR)
        {
            if (sueldoAnual <= tramo1)
            {
                isr = (sueldoAnual - exentoISR) * 0.15;
            }
            else if (sueldoAnual <= tramo2)
            {
                isr = (sueldoAnual - tramo1) * 0.20 + 37_491.00;
            }
            else
            {
                isr = (sueldoAnual - tramo2) * 0.25 + 75_082.00;
            }
        }

        
        sueldoNeto = sueldoBruto - afp - sfs - (isr / 12);

        
        Console.WriteLine("Sueldo Bruto Mensual: RD$ " + sueldoBruto);
        Console.WriteLine("Descuento AFP: RD$ " + afp);
        Console.WriteLine("Descuento SFS: RD$ " + sfs);

        
        if (isr > 0)
        {
            Console.WriteLine("ISR Mensual: RD$ " + (isr / 12));
        }
        else
        {
            Console.WriteLine("ISR: No Aplica");
        }

        Console.WriteLine("Sueldo Neto Mensual: RD$ " + sueldoNeto);
    }
}
  