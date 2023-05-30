using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class ExercicioEntregar {
        class Pessoa {
            private string nome;
            private int anoNascimento;
            private double altura;

            public string Nome {
                get {
                    return nome;
                }
                set {
                    nome = value;
                }
            }

            public int AnoNascimento {
                get {
                    return anoNascimento;
                }
                set {
                    anoNascimento = value;
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
                Console.WriteLine("Ano de Nascimento: " + anoNascimento);
                Console.WriteLine("Altura: " + altura);
            }
            public int CalcularIdade() {
                return  2023 - anoNascimento;
            }
        }
        public static void Executar() {
            Pessoa p = new Pessoa();
            p.Nome = "Joel";
            p.AnoNascimento = 1995;
            p.Altura = 1.76;
            p.ImprimirDados();
            int idade = p.CalcularIdade();
            Console.WriteLine("Idade: " + idade);
        }
    }
}
