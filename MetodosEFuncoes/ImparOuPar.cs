using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class ImparOuPar
    {

        public static void Executar()
        {

            

            Func<int, bool> parImpar = (total) =>
           {

               
               
               if (total % 2 == 0)
               {
                   return true;
                   
               }
               else
               {
                   return false;
                   
               }
           };

            Console.WriteLine(parImpar(21));
        }

    }
}
