using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Digite um valor: ");
            n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= 12)
            {
                
                if(n != 8 && n != 9)
                {
                    Console.WriteLine("O número {0} está no intervalo de 1 a 12 e é diferente de 8 e 9", n);
                }
                else
                {
                    Console.WriteLine("O número tem que ser diferente de {0}", n);
                }
            }
            else
            {
                Console.WriteLine("O número {0} está fora do intervalo", n);
            }

            Console.ReadKey();
        }
    }
}
