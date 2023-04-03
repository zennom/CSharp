using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaIf {
        public static void Executar() {

            double dinheiro = 2500;

            if(dinheiro > 2000) {
                Console.WriteLine("Partiu Nordeste!");
            } else {
                Console.WriteLine("Vou ficar em casa :(");
            }

        }
    }
}
