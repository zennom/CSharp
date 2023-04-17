using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Pessoa {

        public string Nome;
        public int Idade;

        public string Apresentar() {

            return string.Format($"Olá! me chamo {Nome} e tenho {Idade}");
        }

        public void ApresentarNoConsole() {
            // Aqui estou chamando no console o método que criei
            // que é o Apresentar()
            Console.WriteLine(Apresentar());
        }

    }
}
