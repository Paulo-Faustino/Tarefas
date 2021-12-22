using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            operacoes operar = new operacoes();

            Console.Write("N1: ");
            operar.n1 = int.Parse(Console.ReadLine());
            Console.Write("N2: ");
            operar.n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("======== Escolha a Operação ========");
            Console.WriteLine("1 - Adição: ");
            Console.WriteLine("2 - Subtração: ");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.Write("Escollha a Operação: ");
            operar.operacao = int.Parse(Console.ReadLine());

            switch (operar.operacao)
            {
                case 1:
                    Console.WriteLine("Soma: " + operar.Somar());
                    break;
                case 2:
                    Console.WriteLine("Sutração: " + operar.Subtrair());
                    break;
                case 3:
                    Console.WriteLine("Multiplicação: " + operar.Multiplicar());
                    break;
                case 4:
                    Console.WriteLine("Divisão: " + operar.Dividir());
                    break;
                default:
                    Console.WriteLine("Operação Inexistente ! ");
                    break;
            }

            Console.ReadKey();

        }
    }
}
