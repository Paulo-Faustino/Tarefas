using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            double media;
            string nome;
            Console.WriteLine("============= OMICROM ACADEMY ==============");
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());
            media = (n1 + n2) / 2;
            Console.WriteLine("============ PAUTA OMICROM ACADEMY ==============");
            if(media >= 10)
            {
                Console.WriteLine("Nome: {0}\nMédia: {1} valores\nResultado: APROVADO", nome, media);
            }
            else
            {
                Console.WriteLine("Nome: {0}\nMédia: {1} valores\nResultado: REPROVADO", nome, media);
            }
            Console.ReadKey();
        }
    }
}
