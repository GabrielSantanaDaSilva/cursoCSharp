using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digite sua nota: ");
            double n = double.Parse(Console.ReadLine());

            if(n >= 7)
            {
                Console.WriteLine("parabens!!! Você foi aprovado");

            }
            else
            {
                Console.WriteLine("que pena, você foi Reprovado");
            }

        }
    }
}
