using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2,soma,mult,div,sub;
            Console.Write("Digite o primeiro número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            soma = n1 + n2;
            mult = n1 * n2;
            sub = n1 - n2;
            div = n1 / n2;
            Console.WriteLine("A soma entre {0} e {1} é igual {2}",n1,n2,soma);
            Console.WriteLine("A subtração entre {0} e {1} é igual {2}", n1, n2, sub);
            Console.WriteLine("A multiplicação entre {0} e {1} é igual a {2}", n1, n2, mult);
            Console.WriteLine("A divisão entre {0} e {1} é igual a {2}", n1, n2, div);           
            Console.ReadKey();
        }
    }
}
