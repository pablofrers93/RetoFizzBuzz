using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoFizz_Buzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[100];

            SetNumeros(numeros);
            FizzBuzz(numeros);
            Console.ReadLine();
        }

        private static void FizzBuzz(int[] numeros)
        {
            foreach (var numero in numeros)
            {
                if (numero % 3 != 0 && numero % 5 != 0)
                {
                    Console.WriteLine($"{numero}");
                }
                else if (numero % 3 == 0 && numero % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (numero % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else
                    Console.WriteLine("buzz");
            }
        }

        private static void SetNumeros(int[] numeros)
        {
            for (int i=0; i<100; i++)
            {
                numeros[i] = i+1;
            }
        }
    }
}
 