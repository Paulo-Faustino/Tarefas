using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double kmPercorrido,CM,combustivelGasto;
            Console.WriteLine("========= Determinar o Consume Médio ==========");
            Console.Write("Qual foi a distância percorrida? Km: ");
            kmPercorrido = double.Parse(Console.ReadLine());
            Console.Write("Quantos litros gastaram nesses {0} km ?: ", kmPercorrido);
            combustivelGasto = double.Parse(Console.ReadLine());
            CM = combustivelGasto / kmPercorrido;
            Console.WriteLine("O consumo médio é de {0} litros porm km", CM);
            Console.ReadKey();
        }
    }
}
