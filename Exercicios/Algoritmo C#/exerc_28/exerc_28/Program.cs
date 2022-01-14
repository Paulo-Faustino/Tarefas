using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_28
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2,soma,div,sub,mult;
            int operacao;
            Console.Write("Digite o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("1 - Adição(+)");
            Console.WriteLine("2 - Subtração(-)");
            Console.WriteLine("3 - Multiplicação(*)");
            Console.WriteLine("4 - Divisão(+)");

            Console.Write("Escolha a Operação: ");
            operacao = int.Parse(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    soma = n1 + n2;
                    Console.WriteLine("{0} + {1} = {2}", n1, n2, soma);

                    break;
                case 2:
                    div = n1 / n2;
                    Console.WriteLine("{0} / {1} = {2}", n1, n2, div);
                    break;
                case 3:
                    sub = n1 - n2;
                    Console.WriteLine("{0} - {1} = {2}", n1, n2, sub);
                    break;
                case 4:
                    mult = n1 * n2;
                    Console.WriteLine("{0} * {1} = {2}", n1, n2, mult);
                    break;
                default:
                    Console.ReadKey();
                    break;
            }
            Console.ReadKey();

        }
    }
}
