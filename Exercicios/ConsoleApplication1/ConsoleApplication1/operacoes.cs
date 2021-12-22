using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class operacoes
    {
        public int n1 { get; set; }
        public int n2 { get; set; }
        public int operacao { get; set; }

        public int Somar()
        {
            return (n1 + n2);
        }
        
        public double Subtrair()
        {
            return (n1 - n2);
        }

        public int Multiplicar()
        {
            return (n1 * n2);
        }

        public double Dividir()
        {
            return (n1 / n2);
        } 
    }
}
