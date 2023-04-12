using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaFor {
        public static void Executar() {


            Console.WriteLine("Digite um número:");
            int.TryParse(Console.ReadLine(), out int numero);

            for(int contador = 0; contador <= 10; contador++) {
                int resultado = contador * numero;
                Console.WriteLine($" {contador} * {numero} = {resultado}");
            }



            /*
                   Console.WriteLine("Digite um número:");
            int.TryParse(Console.ReadLine(), out int numero);

            for (int contador = 0; contador < numero; contador++) {

                Console.WriteLine(contador);
            }


            int soma = 0;
            for (int contador = 0;contador < 10; contador++) {
                
                Console.WriteLine("Digite um número:");
                int.TryParse(Console.ReadLine(), out int n1);
     
                soma += n1;
            }

            Console.WriteLine($"A soma dos números é:{soma}");

            */

        }
    }
}
