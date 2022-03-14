using System;

namespace _8_Condicional2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicional 2");

            int idadeJoao = 18;
            //int qtdPessoas = 2;
            //bool acompanhado = qtdPessoas >= 2;
            bool acompanhado = false;

            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }

            Console.WriteLine("A execução acabou. Tecle Enter para sair");
            Console.ReadLine();
        }
    }
}
