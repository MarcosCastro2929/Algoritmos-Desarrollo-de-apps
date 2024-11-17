using System;

class Program
{
    static void Main(string[] args)
    {

        int num;
        
        int sumatoria = 0;

        

            while (true) 
        {
            Console.WriteLine("Ingrese un número" );
            num = Convert.ToInt32( Console.ReadLine() );

            if ( num == 0 ) 
            {
                break;

            }

            sumatoria += num;
        }

        Console.WriteLine("La sumatoria de los números ingresados es: " + sumatoria);

    }
}
