using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CursoCSharp.ClassesEMetodos {
    internal class ExerciciosGetESet {
        public class Animal {

            private string nome;
            private string tipo;

            public string Nome {
                get { return nome; }
                set { nome = value; }
            }

            public string Tipo {
                //valores definidos pelo desenvolvedor (cachorro,gato,peixe)
                get { return tipo; }
                set {
                    if (value == "Cachorro" || value == "Gato" || value == "Ave") {
                        tipo = value;
                    } else {
                        tipo = "Ave";
                    }

                }
            }
        }
        public static void Executar() {

            Animal a1 = new Animal();
            Animal a2 = new Animal();
            Animal a3 = new Animal();

            //aqui iremos solicitar o nome do animal para o usuário
            Console.WriteLine("Informe o nome do primeiro animal: ");
            a1.Nome = Console.ReadLine();
            Console.WriteLine("Informe o tipo do primeiro animal: (Cachorro, Gato ou Ave) ");
            a1.Tipo = Console.ReadLine();

            Console.WriteLine($"O nome do animal é: {a1.Nome}");
            Console.WriteLine($"O tipo do animal é :{a1.Tipo}");

        }
    }
}
