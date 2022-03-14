using System;

namespace _9_TestaCondicional2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Testando Condicionais 2");

            int idade = 16;
            // int qtdPessoas = 3;
            bool acompanhado = true;

            if (idade >= 18 && acompanhado)
            {
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("Infelizmente, você não pode entrar.");
            }

            Console.WriteLine("A execução acabou. Tecle Enter para sair!");
            Console.ReadLine();
        }
    }
}
