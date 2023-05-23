using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Valroas
    {
        public string nome;
        public string main;

        public string Apresentar()
        {
            return string.Format($"Oii, sou o {nome} e sou main {main}, bora um duo rs");

            //o método Format retorna uma string formada e imprime no console
        }

        public void ApresentarNoConsole()
        {
            //aqui vou mostrar no console o meu metodo

            Console.WriteLine(Apresentar());
        }
    }
}
