using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Today;
            int anoActual = dt.Year;
            string nome;
            int idade, anoNascimento;
            Console.Write("Qual é o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Quantos anos de idade tens: ");
            idade = int.Parse(Console.ReadLine());
            anoNascimento = anoActual - idade;
            Console.WriteLine("============ Resultados ================");
            Console.WriteLine("Nome: {0}\nIdade:{1} anos\nAno de Nascimento: {2}", nome, idade, anoNascimento);
            Console.ReadKey();
        }
    }
}
