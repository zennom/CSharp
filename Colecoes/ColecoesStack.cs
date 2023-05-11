using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {

    internal class ColecoesStack {

        public static void Executar() {

            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14);

            foreach (var item in pilha) {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"Pop: {pilha.Pop()}");

            foreach (var item in pilha) {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"Pop: {pilha.Peek()}");
            Console.WriteLine(pilha.Count);

        }
    }
}
