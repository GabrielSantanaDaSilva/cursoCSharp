using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Exercicio1GetSet
    {


        class Pessoas
        {

            private string nome;
            private double altura;
            private DateTime datanascimento;

            public string Nome
            {
                get
                {
                    return nome;
                }

                set
                {
                    nome = value;
                }
            }

            public double Altura
            { get; set; }

            public DateTime DataNascimento
            { get; set; }




            public void Imprimir()
            {


                Console.WriteLine($"Olá {Nome} ");
                Console.WriteLine($"Você Nasceu em {DataNascimento} ");
                Console.WriteLine($"E você tem {Altura} metros de altura ");
                Console.WriteLine($"E você tem {DateTime.Today.Year - DataNascimento.Year} anos de idade");
            }


        }
        public static void Executar()
        {

            var pessoa1 = new Pessoas();

            pessoa1.Nome = "cleiton";
            pessoa1.Altura = 1.98;
            pessoa1.DataNascimento = new DateTime(2005, 04, 12);

            pessoa1.Imprimir();

        }
    }
}
