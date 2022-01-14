using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_26
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, capicua = "";
            Console.WriteLine("??????? Verificar se uma Palavra é Capicua ?????????");
            Console.Write("Digite uma palavra? : ");
            nome = Console.ReadLine();

            for(int i = nome.Length - 1; i >= 0; i--)
            {
                capicua += nome[i];
            }

            if(nome.ToLower() == capicua.ToLower())
            {
                Console.WriteLine("A palavra '{0}' é capicua", nome);

            }
            else
            {
                Console.WriteLine("A palavra '{0}' não é capicua", nome);
            }

            Console.ReadKey();
        }
    }
}
