using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Membros {
        public static void Executar() {



            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Josefa";
            pessoa1.Idade = 18;

            Console.WriteLine($"{pessoa1.Nome} tem {pessoa1.Idade} anos");
            pessoa1.ApresentarNoConsole();


        }
    }
}
