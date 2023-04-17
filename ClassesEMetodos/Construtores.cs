using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class Cliente {
        public string Nome;
        public string Cpf;
        public string Sexo;
        public string Endereco;
        public int Idade;

        public Cliente(string nome, string cpf, string sexo, string endereco, int idade) {
            Nome = nome;
            Cpf = cpf;
            Sexo = sexo;
            Endereco = endereco;
            Idade = idade;
        }
        /*vamos criar abaixo um construtor padrão igual o construtor 
         personalizado e com visibilidade publica também  */
        public Cliente() {

        }
    }
    internal class Construtores {
        public static void Executar() {
            var cliente1 = new Cliente();
            cliente1.Nome = "Maria";
            cliente1.Cpf = "12334565678";
            cliente1.Sexo = "F";
            cliente1.Endereco = "Vila Linda";
            cliente1.Idade = 35;

            Console.WriteLine($"{cliente1.Nome} {cliente1.Idade} {cliente1.Endereco} ");

            //usando construtor personalizado
            var cliente2 = new Cliente("José", "12345678918", "M", "Carijós", 70);
        }
    }
}
