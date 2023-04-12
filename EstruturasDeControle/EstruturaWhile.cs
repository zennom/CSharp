using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaWhile {
        public static void Executar() {

            int contador = 1;

            Console.WriteLine("Quer contar até quanto?");
            int.TryParse(Console.ReadLine(), out int valor);

            Console.WriteLine("Qual valor dos saltos?");
            int.TryParse(Console.ReadLine(), out int saltos);

            while(contador < valor) {

                Console.WriteLine(contador);
                contador+=saltos;
            }

            /*
                 int contador = 1;
            Console.WriteLine("Quer contar até quanto?");
            int.TryParse(Console.ReadLine(), out int valor);

            while(contador <= valor) {
                Console.WriteLine(contador);
                contador++;
            }


            int cont = 1;
            while (cont <= 10) {
            
                Console.WriteLine(cont);
                cont++;
            }

            */

        }
    }
}
