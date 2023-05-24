using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class ExercicioEntregar {

        class Pessoa {
            private string nome;
            private DateTime dataNascimento;
            private double altura;

            public string Nome {
                get {
                    return nome;
                }
                set {
                    nome = value;
                }
            }

            public DateTime DataNascimento {
                get {
                    return dataNascimento;
                }
                set {
                    dataNascimento = value;
                }
            }

            public double Altura {
                get {
                    return altura;
                }
                set {
                    altura = value;
                }
            }

            public void ImprimirDados() {
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Data de Nascimento: " + dataNascimento);
                Console.WriteLine("Altura: " + altura);
            }

            public int CalcularIdade() {
                return DateTime.Today.Year - dataNascimento.Year;
            }

        }

        public static void Executar() {

            Pessoa p = new Pessoa();
            p.Nome = "Joel";
            p.DataNascimento = new DateTime(1993, 6, 28);
            p.Altura = 1.76f;

            p.ImprimirDados();

            int idade = p.CalcularIdade();

            Console.WriteLine("Idade: " + idade);

        }
    }
}
