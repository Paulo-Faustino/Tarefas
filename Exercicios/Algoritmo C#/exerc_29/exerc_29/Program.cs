using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Digite um número: ");
            n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois");
                    break;
                case 3:
                    Console.WriteLine("Três");
                    break;
                case 4:
                    Console.WriteLine("Quatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;
                case 6:
                    Console.WriteLine("Seis");
                    break;
                case 7:
                    Console.WriteLine("Sete");
                    break;
                case 8:
                    Console.WriteLine("Oito");
                    break;
                case 9:
                    Console.WriteLine("Nove");
                    break;
                default:
                    Console.WriteLine("Número Inválido!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
