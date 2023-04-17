using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Membros {
        public static void Executar() {

            /*observe que aqui estou criando um
            objeto a partir da classe Pessoa (do arquivo Pessoa.cs) */

            Pessoa pessoa1 = new Pessoa();

            //usando os atributos da classe Pessoa
            pessoa1.Nome = "Josefa";
            pessoa1.Idade = 18;

            //exibindo os dados 
            Console.WriteLine($"{pessoa1.Nome} tem {pessoa1.Idade} anos");

        }
    }
}
