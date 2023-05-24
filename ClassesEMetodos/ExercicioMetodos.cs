using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ExercicioMetodos
    {
        public double RealEmDolar(double a)
        {
            return  a /4.95;
        }

        public double CelsiusEmFahrenheit(double a)
        {
            return a * 1.8 + 32;
        }

        public static void Executar()
        {
            var Exercicio = new ExercicioMetodos();


            Console.WriteLine("Digite o valor para ser convertido: ");
            double real = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a temperatura para ser convertida: ");
            double graus = double.Parse(Console.ReadLine());

            Console.WriteLine($"R${real} na cotação atual dá um total de R${Exercicio.RealEmDolar(real)}");
            Console.WriteLine($"{graus}°C convertidos para fahrenheit da um total de {Exercicio.CelsiusEmFahrenheit(graus)}°F");

        }
    }
}
