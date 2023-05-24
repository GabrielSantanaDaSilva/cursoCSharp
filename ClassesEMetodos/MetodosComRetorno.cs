using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class MetodosComRetorno
    {
           
        class CalculadoraComum { 
         public int Somar (int a, int b)
        {
            return a + b;
        }

        public int Subtrair (int a, int b)
        {
            return a - b;
        }

        public int Multiplicar (int a, int b)
        {
            return a * b;
        }

        public double Divisao(double a, double b)
        {
            return a  /  b;
        }
        }
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();

            var Resultado = calculadoraComum.Somar(55, 32);
            Console.WriteLine(Resultado);



            var R2 = calculadoraComum.Subtrair(100, 54);
            Console.WriteLine(R2);

            var R3 = calculadoraComum.Multiplicar(20, 10);
            Console.WriteLine(R3);


            var R4 =calculadoraComum.Divisao(50, 2);
            Console.WriteLine(R4);


        }
    }
}
