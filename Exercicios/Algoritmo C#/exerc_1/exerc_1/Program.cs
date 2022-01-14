using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Digite um número: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("O número digitado foi {0}", n);
            Console.ReadKey();
        }
    }
}
