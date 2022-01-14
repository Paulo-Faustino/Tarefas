using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_24
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, sexo;
            int totH = 0,totM = 0;

            for(int i = 0; i < 3; i++)
            {
                Console.Write("Digite o seu nome: ");
                nome = Console.ReadLine();
                Console.Write("Escolha o seu sexo\n M \n F\n: ");
                sexo = Console.ReadLine();
                if(sexo.ToLower() == "m")
                {
                    totH += 1;
                    Console.WriteLine("Nome: {0}\nSexo: Masculino",nome);
                    Console.WriteLine(" ");
                }
                else if(sexo.ToLower() == "f")
                {
                    totM += 1;
                    Console.WriteLine("Nome: {0}\nSexo: Femenino", nome);
                    Console.WriteLine(" ");
                }
            }
            Console.WriteLine("Total de Homens: {0}\nTotel de Mulheres: {1}", totH, totM);
            Console.ReadKey();
        }
    }
}
