using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Programa
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Executando projeto 4 - Conversões e outros tipos numéricos");

            float pontoFlutuante = 3.14f;
            Console.WriteLine(pontoFlutuante);

            double salario = 1270.50;
            int valor = (int)salario;
            Console.WriteLine(valor);

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;
            Console.WriteLine(total);

            Console.WriteLine("A execução acabou. Tecle Enter para sair");
            Console.ReadLine();

        }
    }
}
