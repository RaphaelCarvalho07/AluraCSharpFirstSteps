using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_TestaCondicional2
{
    class Programa
    {
        static void Main( string[ ] args )
        {
            Console.WriteLine( "Executando projeto 10 - Testando Escopo" );

            int idade = 20;
            int quantidadePessoas = 3;
            bool acompanhado;

            if (quantidadePessoas >= 2)
            {
                acompanhado = true;
            }
            else
            {
                acompanhado = false;
            }

            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine( "Seja bem vindo" );
            }
            else
            {
                Console.WriteLine( "Infelizmente, você não pode entrar!" );
            }

            Console.WriteLine( "A execução acabou. Tecle Enter para sair!" );
        }
    }
}