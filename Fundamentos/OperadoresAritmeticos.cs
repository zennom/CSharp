using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresAritmeticos {
        public static void Executar() {


            Console.Write("Digite a base: ");
            var base1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura: ");
            var altura1 = double.Parse(Console.ReadLine());

            double resposta = (base1 * altura1) / 2;

            Console.WriteLine($"As dimensões de um triângulo são: {resposta}");



            /*

            Console.Write("Digite um número:");
            var n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite outro número:");
            var n2 = double.Parse(Console.ReadLine());

            double resultado = n1 + n2;

            Console.WriteLine($"O resultado é {resultado}");

            */

        }
    }
}
