using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_19
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposito,rendimento;
            Console.WriteLine("======= Depósito a Prazo ============");
            Console.Write("Quanto é que depositaste? : ");
            deposito = double.Parse(Console.ReadLine());
            rendimento = deposito + (deposito * 0.007);
            Console.WriteLine("O valor que tens a receber é {0}kz", rendimento);
            Console.ReadKey();
        }
    }
}
