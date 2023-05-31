using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Exercicio2GetSet
    {
        class Alunos
        {
            public double n1;
            public double n2;
            public double n3;

            public Alunos(double N1, double N2, double N3)
            {
                n1 = N1;
                n2 = N2;
                n3 = N3;

            }


            public double Media
            {
                get
                {
                    return (n1 + n2 + n3) / 3;
                }
            }
        }

        public static void Executar()
        {
            var aluno1 = new Alunos(10, 5, 10);


            Console.WriteLine($"sua média deu um total de {aluno1.Media.ToString("##.#")}");

        }
    }
}
