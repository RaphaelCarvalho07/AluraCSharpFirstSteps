using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AliquotaComIF
{
    internal class Program
    {
        static void Main( string[ ] args )
        {
            Console.WriteLine( "Executando projeto 11 - Aliquota com IF" );

            double salario = 3300.0;

            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine( "Sua alíquota é de 7,5% e você pode deduzir na declaração até R$142" );
            }
            else if (salario >= 2800.01 && salario <= 3751.0)
            {
                Console.WriteLine( "Sua alíquota é de 15% e você pode deduzir na declaração até R$350" );
            }
            else if (salario >= 3751.01 && salario <= 4664.0)
            {
                Console.WriteLine( "Sua alíquota é de 22,5% e você pode deduzir na declaração até R$636" );
            }

            else
            {
                Console.WriteLine( "Você não tem alíquota pré-definida" );
            }
        }
    }
}
