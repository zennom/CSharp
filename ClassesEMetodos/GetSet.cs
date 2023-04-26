using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CursoCSharp.ClassesEMetodos {
    class Cliente {
        private string nome;
        public string Nome {
            get {
                return nome;
            }
            set { 
                nome = value; 
            }
        }
    }
    internal class GetSet {
        public static void Executar() {
            //vamos instanciar um objeto da classe Cliente
            Cliente cliente1 = new Cliente();

            //aqui é um exemplo de GET = cliente1.Nome

            //aqui estou usando o SET para enviar uma informação
            cliente1.Nome = "Naruto";

            //exibindo no console
            Console.WriteLine(cliente1.Nome);

        }
    }
}
