using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_22
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, nomeEncriptado;
            nomeEncriptado = "";
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            for (int i = nome.Length - 1;i >= 0; i--)
            {
                nomeEncriptado += nome[i];
            }
            Console.WriteLine("O seu encriptado fica {0} ", nomeEncriptado);
            Console.ReadKey();
        }
    }
}
