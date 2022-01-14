using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_18
{
    class Program
    {
        static void Main(string[] args)
        {
            double us, kz;
            double valorDolar = 700;
            Console.WriteLine("========== Conversor de Moedas =========");
            Console.Write("Quantos Doláres queres converter? : ");
            us = double.Parse(Console.ReadLine());
            kz = us * valorDolar;
            Console.WriteLine("{0}$ é equivalente a {1} kz", us, kz);
            Console.ReadKey();

        }
    }
}
