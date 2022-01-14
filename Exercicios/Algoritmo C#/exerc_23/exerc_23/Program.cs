using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======== Números Naturais Ímpares ========");
            for(int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
