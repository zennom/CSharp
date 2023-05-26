using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    internal class Abstract {
     
        public abstract class Celular {
            public abstract string Assistente();

            public string Tocar() {
                return "Trim trim trim....";
            }
        }
        public class Samsung: Celular {
            public override string Assistente() {
                return "Olá meu nome é Bixby";
            }
        }
        public class Iphone: Celular {
            public override string Assistente() {
                return "Olá meu nome é Siri";
            }
        }
        public static void Executar() {
            //como não podemos instanciar uma classe abstrata
            //(a classe Celular é abstrata)
            //podemos criar uma lista
            var celulares = new List<Celular> {
                new Samsung(),
                new Iphone()
            };
            //então podemos percorrer essa lista e chamar o assistente
            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
