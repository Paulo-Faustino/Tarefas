using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.Write("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            if(n1 > n2)
            {
                Console.WriteLine("O maior entre {0} e {1} é {0}", n1, n2);

            }else if(n2 > n1)
            {
                Console.WriteLine("O maior entre {0} e {1} é {1}", n1, n2);
            }
            else
            {
                Console.WriteLine("Os números são iguais");
            }
            Console.ReadKey();
        }
    }
}
