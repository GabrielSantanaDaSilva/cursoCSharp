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
            /*Console.WriteLine("Digite sua nota: ");
            double n = double.Parse(Console.ReadLine());

            if(n >= 7)
            {
                Console.WriteLine("parabens!!! Você foi aprovado");

            }
            else
            {
                Console.WriteLine("que pena, você foi Reprovado");
            }*/


            /* Console.WriteLine("Qual o ano do seu nascimento?:");
             int idade = int.Parse(Console.ReadLine());

             idade = 2023 - idade;


             if(idade < 17 || idade > 69)
             {
                 Console.WriteLine($"Você tem {idade} anos, seu voto é opcional");


             }
             if(idade > 17 && idade < 70)
             {
                 Console.WriteLine($"Você tem {idade} anos, seu voto é obrigatório");
             }else

                 Console.WriteLine($"{idade}");*/

            /* var senha = "batata2";

             Console.WriteLine("Dígite seu nome:");
             var nome = Console.ReadLine();

             Console.WriteLine("Dígite a sua senha:");
             var senha2 = Console.ReadLine();

             if (senha2 == senha)
             {
                 Console.WriteLine($"Seja bem vindo {nome}");
             }
             else
             {
                 Console.WriteLine($"Senha invalida");
             }*/


           /* Console.WriteLine( "digite sua priemira nota:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite sua priemira nota:");
            double n2 = double.Parse(Console.ReadLine());
*/
            /*
                        Console.WriteLine("digite sua priemira nota:");
                        double n3 = double.Parse(Console.ReadLine());

                        if((n1+n2+n3)/3 >= 7)
                        {
                            Console.WriteLine($"parabens você passou de ano com {(n1+n2+n3)/3} de média");
                        }if ((n1 + n2 + n3) / 3 >= 5 && (n1 + n2 + n3) / 3 < 7) ;
                        {
                            Console.WriteLine($"Eita, você ficou de recuperação com {(n1 + n2 + n3) / 3} de média");
                        }if((n1 + n2 + n3) / 3 < 5)
                        {
                            Console.WriteLine($"Puts, você reprovou de ano com {(n1+n2+n3)/3} de média");
                        }
            */

            Console.WriteLine("Digite seu peso");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura");
            double altura = double.Parse(Console.ReadLine());

            double media = peso / (altura * altura);


            if (media < 18.5)
            {
                Console.WriteLine($"Você está abaixo do peso com um total de {media.ToString("#.#")} imc");
            }
            else if(media >= 18.5 && media<=24.9)
            {
                Console.WriteLine($"Você está com um peso normal com um total de {media.ToString("#.#")} imc");
            }else if (media > 24.9 && media<=29.9)
            {
                Console.WriteLine($"Você está acima do peso com um total de {media.ToString("#.#")} imc");
            }else if (media >29.9 && media <=34.9)
            {
                Console.WriteLine($"Você está com obesidade grau I com um total de {media.ToString("#.#")} imc");
            }else if (media >34.9 && media <=39.9)
            {
                Console.WriteLine($"Você está com obesidade grau II com um total de {media.ToString("#.#")} imc");
            }else if (media > 39.9)
            {
                Console.WriteLine($"Você está com obesidade grau III com um total de {media.ToString("#.#")} imc");
            }


        }
    }
}
            
        
    

