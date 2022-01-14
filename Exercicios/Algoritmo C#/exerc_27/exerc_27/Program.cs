using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string pos = " ", neg = " ", zer = " ";

            for(int i = 0; i < 5; i++)
            {
                Console.Write("Digite um número: ");
                n = int.Parse(Console.ReadLine());
                if(n < 0)
                {
                    neg += n;
                }else if(n == 0)
                {
                    zer += n;
                }
                else
                {
                    pos += n;
                }
            }
            Console.WriteLine("Números Negativos: {0}", pos);
            Console.WriteLine("Números Nulos: {0}", zer);
            Console.WriteLine("Números Positivos: {0}", neg);
            Console.ReadKey();
        }
    }
}
