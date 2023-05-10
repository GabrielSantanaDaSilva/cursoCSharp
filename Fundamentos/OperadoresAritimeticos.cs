using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritimeticos
    {
        public static void Executar()
        {
            Console.WriteLine("Dígite um Número:");
            double  n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Dígite outro Número:");
            double  n2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{n1} + {n2} = {n1+n2}");
            Console.WriteLine($"{n1} - {n2} = {n1-n2}");
            if (n1 == 0  || n2 == 0) {

                Console.WriteLine($"Não é possivel dividir 0");
            }
            else { Console.WriteLine($"{n1} / {n2} = {n1 / n2}"); };

            
            Console.WriteLine($"{n1} x {n2} = {n1*n2}");



           /* Console.WriteLine("Digite o Valor da base do seu triangulo:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura do seu trinagulo:");
            double n2 = double.Parse(Console.ReadLine());


            Console.WriteLine($"({n1} x {n2})/2 = {(n1 * n2) / 2}  ");*/
            


        }
    }
}
