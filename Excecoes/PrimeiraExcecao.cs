using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    class PrimeiraExcecao
    {
        
            public class Conta
        {
            private double Saldo;

            public Conta(double saldo)
            {
                Saldo = saldo;
            }

            public void Sacar(double valor)
            {
                if(valor > Saldo)
                {
                    throw new ArgumentException("Saldo Insuficiente");
                }
                else
                {
                    Saldo -= valor;
                }

            }
        }


        public static void Executar()
        {
            var Conta = new Conta(600000);

            try
            {
                Conta.Sacar(500);
                Console.WriteLine( "Valor retirado da sua conta");
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Muito obrigado risos..");
            }
        }

    }
    }
}
