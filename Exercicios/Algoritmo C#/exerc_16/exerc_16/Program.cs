using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double F, C;
            Console.WriteLine("======= Conversor de Temperatura ==========");
            Console.Write("Quantos graus celius está o clima? Cº : ");
            C = double.Parse(Console.ReadLine());
            F = (9 * C + 160) / 5;
            Console.WriteLine("{0}º Celsius é equivalente a {1}º Fahrenheit",C,F);
            Console.ReadKey();
        }
    }
}
