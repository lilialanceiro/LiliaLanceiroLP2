using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaApoio
{
    class Program
    {
        static void Main(string[] args)
        {
            ex2();
        }

        static void ex1()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());


            while (p <= q)
            {
                if (p % n == 0)
                {
                    Console.WriteLine(p);
                }
                p++;

            }
        }

        static void ex2()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                int lado1 = int.Parse(Console.ReadLine());
                int lado2 = int.Parse(Console.ReadLine());
                int lado3 = int.Parse(Console.ReadLine());

                if(lado1 == lado2 && lado1 == lado3)
                {
                    Console.WriteLine("É equilátero");
                }
                if (lado1 == lado2 && lado2 != lado3)
                {
                    Console.WriteLine("É isósceles");
                }

                if (lado1 != lado2 && lado2 == lado3)
                {
                    Console.WriteLine("É isósceles");
                }

                if(lado1 == lado3 && lado2 != lado3)
                {
                    Console.WriteLine("É isósceles");
                }

                if(lado1 != lado2 && lado2 != lado3)
                {
                    Console.WriteLine("É escaleno");

                    if (lado1 * lado1 == lado2 * lado2 + lado3 * lado3)
                    {
                        Console.WriteLine("É Triângulo retângulo");
                    }
                    else
                    {
                        Console.WriteLine("Não é Triângulo retângulo");
                    }
                }

               

                
            }
        }
    }
}
