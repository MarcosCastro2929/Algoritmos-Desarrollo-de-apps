using System;

class Program
{
    static void Main(string[] args)
    {


        int contraseña_definida = 1234;
        int contraseña_ingresada; 


            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese la contraseña: ");
                contraseña_ingresada = Convert.ToInt32(Console.ReadLine());

                if (contraseña_ingresada == contraseña_definida)
                {
                    Console.WriteLine("La contraseña es correcta");
                    return;
                }

                else
                {
                    Console.WriteLine("La contraseña es incorrecta");
                  
                    
                }

            
        }


        Console.WriteLine("Ha agotado el número de intentos");












    }
}
