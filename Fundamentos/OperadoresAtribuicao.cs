using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresAtribuicao {

        public static void Executar() {
            //ATRIBUIÇÃO
            var num = 3;

            //substituindo o número 3 por 7
            num = 7;

            //ATRIBUIÇÃO ADITIVA
            num += 10; /*isso é a mesma coisa que num = num + 10
            aqui eu estou ACRESCENTANDO mais um valor a variável num
            que tinha 7 e eu incremento com mais 10, então passa a ser 17 */

            //ATRIBUIÇÃO SUBTRATIVA
            num -= 3; /* num vai receber o próprio num menos 3 (num = num - 3)  */

            Console.WriteLine(num);

            //INCREMENTO E DECREMENTO
            var a = 1;
            var b = 1;

            a++; // a = a + 1
            b--; //b = b - 1

            Console.WriteLine($" {a} {b}");
        }
    }
}
