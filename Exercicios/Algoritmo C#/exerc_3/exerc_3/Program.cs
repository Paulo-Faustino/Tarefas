using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            Console.WriteLine("========== Comparando Números========");
            Console.Write("Digite o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = double.Parse(Console.ReadLine());
            if(n1 == n2)
            {
                Console.WriteLine("{0} e {1} são iguais. ",n1,n2);
            }
            else
            {
                Console.WriteLine("{0} e {1} são diferentes. ",n1,n2);
            }
            Console.ReadKey();
        }
    }
}
