using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class Polimorfismo { 

        public class Comida
    {
        public double Peso;

        public Comida(double peso)
            {
                Peso = peso;
            }

        public Comida() { }
    }
        
        public class Arroz : Comida
        {
            public double Peso;
        }
        public class Feijao : Comida
        {
            public double Peso;
        }
        public class Carne : Comida
        {
            public double Peso;
        }

        public class Pessoa 
        {
            public double Peso;
        public void Comer(Comida comida)
        {
            Peso += comida.Peso;
        }

           /* public void Comer(Arroz arroz)
            {
                Peso += arroz.Peso;
            }

            public void Comer(Carne carne)
            {
                Peso += carne.Peso;
            }*/

        }
        public static void Executar()
        {
            Arroz ingrediente1 = new Arroz();
            ingrediente1.Peso = 0.4;

            Feijao ingrediente2 = new Feijao();
            ingrediente2.Peso = 0.3;

            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.8;

            Pessoa Cliente = new Pessoa();
            Cliente.Peso = 78.5;

            Cliente.Comer(ingrediente1);
            Cliente.Comer(ingrediente2);
            Cliente.Comer(ingrediente3);
            Console.WriteLine($"seu cliente agora tem {Cliente.Peso} Kg");
        }
    }
}
