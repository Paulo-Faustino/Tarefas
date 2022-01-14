using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int maioridade = 18;
            string nome;

            for(int i = 0; i < 7; i++)
            {
                Console.Write("Digite Seu nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("{0} a maioridade é {1k} anos",nome,maioridade);
                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }
    }
}
