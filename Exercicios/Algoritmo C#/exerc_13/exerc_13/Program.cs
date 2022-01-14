using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("{0} o seu nome tem {1} letras.", nome, nome.Length);
            Console.ReadKey();
        }
    }
}
