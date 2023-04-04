using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaIf {
        public static void Executar() {

            Console.Write("Digite a primeira nota: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double n3 = double.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3;

            if(media > 7.0) {
                Console.WriteLine($"Sua nota foi {media.ToString("#.##")} você está aprovado");
            } else {
                Console.WriteLine($"Sua nota foi {media.ToString("#.##")} você está reprovado");
            }


            /*

            double dinheiro = 2500;

            if(dinheiro > 2000) {
                Console.WriteLine("Partiu Nordeste!");
            } else {
                Console.WriteLine("Vou ficar em casa :(");
            }
            */
        }
    }
}
