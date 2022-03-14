using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicional IF");

            int idade = 20;
            int qtdPessoas = 3;

            if (idade >= 18)
            {
                Console.WriteLine("Você tem mais que 18 anos!");
                Console.WriteLine("Seja Bem-Vindo!");
            }
            else if (qtdPessoas >= 2)
            {
                Console.WriteLine("Você não tem 18, mas pode entrar, pois está acompanhado! =P");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar =(");
            }

            Console.WriteLine("A execução acabou. Tecle Enter para sair");
            Console.ReadLine();
        }
    }
}
