using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_TransformandoWhileEmFor
{
    internal class Program
    {
        static void Main( string[ ] args )
        {
            Console.WriteLine( "Executando projeto 14 - Laço de Repetição For - Transformando While em For" );

            /*int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine( contador );
                contador++;
            }*/

            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine( contador );
            }
        }
    }
}
