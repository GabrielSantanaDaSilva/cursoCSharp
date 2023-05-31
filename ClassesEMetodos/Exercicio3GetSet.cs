using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Exercicio3GetSet
    {

        class Animais
        {
            private string nome;
            private string animal;

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

            public string Animal
            {
                get
                {
                    return animal;
                }
                set
                {
                    animal = value;
                }


            }

            public void Aparecer()
            {
                if (Animal == "gato" || Animal == "cachorro")
                {

                    Console.WriteLine($"Tudo bem o(a) {Nome} é um(a) {Animal}");

                }
                else
                {
                    Console.WriteLine($"Tudo bem o(a) {Nome} é uma Ave");
                }
            }





        }
        public static void Executar()
        {

            var animal1 = new Animais();

            Console.WriteLine("Digite o nome do seu pet: ");
            animal1.Nome = Console.ReadLine();

            Console.WriteLine("Digite qual é o seu animal");
            animal1.Animal = Console.ReadLine();

            animal1.Aparecer();


        }


    }

}

