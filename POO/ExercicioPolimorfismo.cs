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
            public string Cnpj;
        }

        public class Fisico : Cliente
        {
            public string Cpf;

        }

        
        public static void Executar()
        {
            

            Fisico CleitonFisico = new Fisico ();
            Cliente CleitonJuridico = new Juridico();
           

                 Console.WriteLine($" digite o tipo de cliente que você é: ");
                 Console.WriteLine("1-> Fisico");
                 Console.WriteLine("2-> Jurídico");
            var tipo = Console.ReadLine();
        if( tipo == "1"){

                 Console.WriteLine($"Digite seu nome:");
                 CleitonFisico.Nome = Console.ReadLine();
                 Console.WriteLine($"{CleitonFisico.Nome} informe seu CPF:");
                 CleitonFisico.Cpf = Console.ReadLine();
                            

                Console.WriteLine($"{CleitonFisico.Nome} Você é um cliente Fisíco Válido");
        }else if(tipo == "2")
                        {
                
            
                Console.WriteLine($"Digite seu nome");
                CleitonJuridico.Nome = Console.ReadLine();
                Console.WriteLine($"{CleitonJuridico.Nome} Informe seu CNPJ:");
                var cnpj = Console.ReadLine();



                Console.WriteLine($"{CleitonJuridico.Nome} Você é um cliente Jurídico Válido"); 
            }


        }
    }
}
