using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_TestaPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando variáveis ponto flutuante");

            double salario;
            salario = 1250.70;

            Console.WriteLine(salario);

            int divisao = 5 / 2;
            Console.WriteLine(divisao);

            double division = 5.0 / 2;
            Console.WriteLine(division);

            Console.WriteLine("A execução acabou. Tecle Enter para sair");
            Console.ReadLine();
        }
    }
}
