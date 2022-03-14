using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_WhileCalculaPoupanca
{
    internal class Program
    {
        static void Main( string[ ] args )
        {
            Console.WriteLine( "Executando projeto 13 - Laço de Repetição While - Calcula Poupança" );

            double valorInvestido = 1000;
            int contadorMes = 1;

            // 0.36 == 0.0036
            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine( $"Após {contadorMes}, você terá R${valorInvestido}" );
                contadorMes++;
            }
           


        }
    }
}
