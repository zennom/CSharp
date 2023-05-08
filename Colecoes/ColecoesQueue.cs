using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ColecoesQueue {

        public static void Executar() {
            
            var fila = new Queue<string>();

            fila.Enqueue("Naruto");
            fila.Enqueue("Sasuke");
            fila.Enqueue("Kakashi");
            fila.Enqueue("Sakura");

            
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            //verificando quantas pessoas temos na fila
            foreach(var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

        }
    }
}
