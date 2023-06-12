using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class ExercicioPolimorfismo
    {

        public class Cliente
        {
            public string Nome;
            public string Tipo;
        }

        public class Juridico : Cliente
        {
            public string cnpj;
        }

        public class Fisico : Cliente
        {
            public string cpf;

        }

        
        public static void Executar()
        {
            

            Cliente Cleiton = new Cliente();


            Console.WriteLine($"Digite seu nome");

            Cleiton.Nome = Console.ReadLine();

            Console.WriteLine($"{Cleiton.Nome} digite o tipo de cliente que você é: ");
            Console.WriteLine("1-> Fisico");
            Console.WriteLine("2-> Jurídico");
            Cleiton.Tipo = Console.ReadLine();

            if(Cleiton.Tipo == "1")
            {

                
                Console.WriteLine($"{Cleiton.Nome} informe seu CPF:");
                var cpf = Console.ReadLine();

                Console.WriteLine($"{Cleiton.Nome} Você é um cliente Fisíco Válido");
            }else if(Cleiton.Tipo == "2")
            {


                Console.WriteLine($"{Cleiton.Nome} Informe seu CNPJ:");
                var cnpj = Console.ReadLine();
                Console.WriteLine($"{Cleiton.Nome} Você é um cliente Jurídico Válido"); 
            }


        }
    }
}
