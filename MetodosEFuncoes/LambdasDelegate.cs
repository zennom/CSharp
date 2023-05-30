using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CursoCSharp.MetodosEFuncoes {
    delegate double Operacao(double x, double y);
    internal class LambdasDelegate {

        public static void Executar() {
            /*observe que o delegate já 
            me notificou que eu tenho um 
            double x e double y */
            Operacao sum = (x,y) =>  x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            /*uma vez que você cria uma variável
             * do tipo delegate espera-se que seja
             atribuido uma função que respeite sua 
            assinatura, ou seja, seu tipo*/

            Console.WriteLine(sum(2,2));
        }
    }
}
