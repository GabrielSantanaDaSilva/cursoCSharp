using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class Sealed
    {
        sealed class SemFilho
        {
            public double ValorDaFortuna()
            {
                return 132.3453543643321312;
            }

        /*class SouFilho : SemFilho*/
            class Avo
            {
                public virtual bool HonrarNomeFamilia()
                {
                    return true;
                }

            }

            class Pai : Avo
            {
                public override bool HonrarNomeFamilia()
                {
                    return true;
                }
            }

            class FilhoRebelde : Pai
            {
                public override bool HonrarNomeFamilia()
                {
                    return true;
                }
            }
        }
        public static void Executar()
        {
            

            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

           
        }
    }
}
