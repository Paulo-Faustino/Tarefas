using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int candidato = 0;
            int cvr = 0, jam = 0, cfl = 0, lcp = 0, atv = 0,nulo=0;
            Console.WriteLine("======== Eleições da Turma B208 ==========");
            Console.WriteLine("1 - Cristiano Vladimir Rodrigues");
            Console.WriteLine("2 - Jorge António Muxito");
            Console.WriteLine("3 - Cristiano Francisco Lourenço");
            Console.WriteLine("4 - Lucrécia Da Conceição Palanga");
            Console.WriteLine("5 - Ana Tavares Viegas");

         for(int i = 0; i < 10; i++)
            {
                Console.Write("O seu voto vai para o candidato Nº: ");
                candidato = int.Parse(Console.ReadLine());
                switch (candidato)
                {
                    case 1:
                        cvr += 1;
                        Console.WriteLine("1 - Cristiano Vladimir Rodrigues");
                        Console.WriteLine(" ");
                        break;
                    case 2:
                        jam += 1;
                        Console.WriteLine("2 - Jorge António Muxito");
                        Console.WriteLine(" ");
                        break;
                    case 3:
                        cfl += 1;
                        Console.WriteLine("3 - Cristiano Francisco Lourenço");
                        Console.WriteLine(" ");
                        break;
                    case 4:
                        lcp += 1;
                        Console.WriteLine("4 - Lucrécia Da Conceição Palanga");
                        Console.WriteLine(" ");
                        break;
                    case 5:
                        atv += 1;
                        Console.WriteLine("5 - Ana Tavares Viegas");
                        Console.WriteLine(" ");
                        break;
                    default:
                        nulo += 1;
                        Console.WriteLine("Voto Nulo");
                        Console.WriteLine(" ");
                        break;
                }
            }

            Console.WriteLine("======== Resultado das Eleições da Turma B208 ==========");
            Console.WriteLine("1 - Cristiano Vladimir Rodrigues --- {0} votos",cvr);
            Console.WriteLine("2 - Jorge António Muxito ----------- {0} votos",jam);
            Console.WriteLine("3 - Cristiano Francisco Lourenço --- {0} votos",cfl);
            Console.WriteLine("4 - Lucrécia Da Conceição Palanga -- {0} votos",lcp);
            Console.WriteLine("5 - Ana Tavares Viegas ------------- {0} votos",atv);
            Console.WriteLine("6 - Votos Nulos -------------------- {0} votos",nulo);
          
            Console.ReadKey();

        }
    }
}
