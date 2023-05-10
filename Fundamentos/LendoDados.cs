using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class LendoDados {

        public static void Executar() {

            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade?");
            // fazendo a conversao de um inteiro
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a sua altura?");
            //fazendo a conversao de um decimal
            double altura = double.Parse(Console.ReadLine()) ;

            Console.WriteLine($"Olá {nome} você tem {idade} anos e {altura} metros de altura");
        }

    }
}
