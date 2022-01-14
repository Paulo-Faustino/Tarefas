using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Digite um valor: ");
            n = int.Parse(Console.ReadLine());
            if(n >= 100 && n <= 200)
            {
                Console.WriteLine("O número {0} está no intervalo de 100 a 200", n);
            }
            else
            {
                Console.WriteLine("O número {0} está fora do intervalo de 100 a 200", n);
            }

            Console.ReadKey();
        }
    }
}
