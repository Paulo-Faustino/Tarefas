using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("========= Verificador de Par ou Ímpar ===========");
            Console.Write("Digite um número: ");
            n = int.Parse(Console.ReadLine());
            if(n%2 == 0)
            {
                Console.WriteLine("O número {0} é PAR", n);
            }
            else
            {
                Console.WriteLine("O número {0} é ÍMPAR", n);
            }
            Console.ReadKey();
        }
    }
}
