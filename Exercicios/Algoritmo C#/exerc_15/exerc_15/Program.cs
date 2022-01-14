using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,c;
            Console.WriteLine("====== Troca de Valores ========");
            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(" ============ Trocando Vaores ========");
            c = a;
            a = b;
            b = c;
            Console.WriteLine("A = {0}", a);
            Console.WriteLine("B = {0}", b);
            Console.ReadKey();
        }
    }
}
