using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime n1 = DateTime.Today;
            string nome;
            int anoActual = n1.Year,anoNascimento,idade;
            Console.WriteLine("========== Informações Pessoais ==========");
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o ano em que foste nascido: ");
            anoNascimento = int.Parse(Console.ReadLine());
            idade = anoActual - anoNascimento;
            Console.WriteLine("======== Resultado ===========");
            Console.WriteLine("Nome: {0}\nAno de Nascimento: {1}\nIdade: {2}", nome, anoNascimento, idade);
            Console.ReadKey();
        }
    }
}
