using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========= Verificando os nomes ===========");
            string nome1, nome2, nome3;
            Console.Write("1 - Digite o seu nome: ");
            nome1 = Console.ReadLine();
            Console.Write("2 - Digite o seu nome: ");
            nome2 = Console.ReadLine();
            Console.Write("3 - Digite o seu nome: ");
            nome3 = Console.ReadLine();

            if(nome1.ToLower() == nome2.ToLower() && nome2.ToLower() == nome3.ToLower())
            {
                Console.WriteLine("Os nomes são iguais");
            }
            else
            {
                Console.WriteLine("Os nomes são diferentes");
            }

            Console.ReadKey();
        }
    }
}
