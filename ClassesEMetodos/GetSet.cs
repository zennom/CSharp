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
            Cliente cliente1 = new Cliente();
            cliente1.Nome = "Naruto";
            Console.WriteLine(cliente1.Nome);

        }
    }
}
