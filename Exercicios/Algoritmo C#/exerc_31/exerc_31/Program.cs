using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.Write("Quantos anos de idade tens? : ");
            idade = int.Parse(Console.ReadLine());
            if(idade < 5)
            {
                Console.WriteLine("É um Bebé!");
            }
            else if(idade < 12)
            {
                Console.WriteLine("É uma Criança!");
            }
            else if(idade < 18)
            {
                Console.WriteLine("É um Adolescente!");
            }else if(idade < 35)
            {
                Console.WriteLine("É um Jovem!");
            }else if(idade < 55)
            {
                Console.WriteLine("É um Senhor!");
            }
            else
            {
                Console.WriteLine("É um velho !");
            }

            Console.ReadKey();
        }
    }
}
