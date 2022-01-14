using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int s=0, n;
            Console.Write("Queres saber a soma de que primeiros números naturais? : ");
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                s += i;
            }

            Console.WriteLine("A soma dos {0} números naturais é igual a {1}", n, s);
            Console.ReadKey();
        }
    }
}
