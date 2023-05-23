using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoas
    {

        /*Estamos colocando o tipo public para que o atributo fique visivel para a classe.
         * na vida real temos atributos que precisam ser publicos e outros privados
         */
        public string Nome;
        public int Idade;


        public string Apresentar()
        {
            return string.Format($"Olá me chamo {Nome} e tenho {Idade} anos de idade");

            //o método Format retorna uma string formada e imprime no console
        }

        public void ApresentarNoConsole()
        {
            //aqui vou mostrar no console o meu metodo

            Console.WriteLine(Apresentar());
        }
    }
}
