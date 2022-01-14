using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_17
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, d, a, b, c;
            Console.WriteLine("============== Equação do II grau ============");
            Console.Write("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            c = double.Parse(Console.ReadLine());

            d = ((b * b) - 4*(a)*(c));
            Console.WriteLine("Delta = {0}", d);

            if(d < 0)
            {
                Console.WriteLine("Não tem solução");
            }
            else if(d == 0)
            {
                x1 = ((-(b)) / 2 * a);
                x2 = x1;

                Console.WriteLine("X1 = {0}\nX2 = {1}", x1, x2);
            }
            else
            {
                x1 = ((-(b) + Math.Sqrt(d)) / 2 * a);
                x2 = ((-(b) - Math.Sqrt(d)) / 2 * a);
                Console.WriteLine("X1 = {0}\nX2 = {1}", x1, x2);
            }

            Console.ReadKey();
        }
    }
}
