using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class GetSet
    {

        class Cliente
        {

            // private garente que apenas a class cliente tenha os dados
            private string nome;

            // mas em algum momento vamos ter q pegar o valor deste nome 
            // para isso usaremos GET e SET
            // GET PEGA O  VALOR
            // SET ENVIA O VALOR

            // GET E SET precisam ser iguais ao atributo
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
        }

        public static void Executar()
        {
            Cliente cliente1 = new Cliente();

            //Exemplo de GET cliente.Nome;

            //Usando o set

              cliente1.Nome = "cleiton";
            Console.WriteLine(cliente1.Nome);
        }
    }
}
