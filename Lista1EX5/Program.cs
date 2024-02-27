using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Digite os lados do triangulo:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());



            if (a < b + c && b < a + c && c < a + b)
            {

                Console.WriteLine("Seu triangulo é:");

                if (a == b && b == c)
                {
                    Console.WriteLine("Equilátero.");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Isósceles.");
                }
                else
                {
                    Console.WriteLine("Escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Não é Triângulo");

            }

            Console.ReadKey();
        }
    }
}
