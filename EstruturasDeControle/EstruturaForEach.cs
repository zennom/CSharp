using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaForEach {
        public static void Executar() {

            //percorrendo uma palavra
            var palavra = "Olá!";

            foreach(var letra in palavra) {
                Console.WriteLine(letra);
            }

            //percorrendo um array
            var alunos = new string[] { "Ana", "Bia", "João" };
            foreach(string aluno in alunos) {
                Console.WriteLine(aluno);
            }

        }

    }
}
