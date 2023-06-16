using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Palmeiras Não tem Mundial");
            };

            /*algoNoConsole();*/

            Func<int> JogarDados = () =>
            {
                Random random = new Random();
                return random.Next(1,6);
            };

            Console.WriteLine(JogarDados());

        }
    }
}
