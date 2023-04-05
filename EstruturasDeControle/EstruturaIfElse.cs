using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaIfElse {
        public static void Executar() {

            double dinheiro = 2.500;

            if(dinheiro >= 5.000) {
                Console.WriteLine("Partiu Nordeste! 8D");
            }
            else if(dinheiro >= 2.000 && dinheiro <= 3.000) {
                Console.WriteLine("Partiu Praia Grande! =D");
            } else {
                Console.WriteLine("Vou ficar em casa :(");
            }

        }
    }
}
