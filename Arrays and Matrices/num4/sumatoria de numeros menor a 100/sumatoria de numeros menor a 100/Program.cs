using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantos numeros quieres ingresar: ");
            int[] posiciones = new int[Convert.ToInt32(Console.ReadLine())];
            int[] numeros1 = new int[posiciones.Length];

            for (int i = 0; i < posiciones.Length; i++)
            {
                Console.Write("Ingresa el numero: ");
                numeros1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");
            Console.Write(numeros1.Sum());


            if (numeros1.Sum() >= 100)
            {
                Console.Write("Es mayor o igual a 100");
            }
            else
            {
                Console.Write("No es mayor o igual a 100");

            }

            Console.ReadKey();
        }
    }
}
