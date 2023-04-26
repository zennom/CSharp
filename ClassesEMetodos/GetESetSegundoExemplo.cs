using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class GetESetSegundoExemplo {
        public class CarroOpcional{
            double desconto = 0.1;
            string nome;
            public string Nome {
                get {
                    return "Opcional " + nome;
                }
                set { 
                    nome = value;
                }
            }
            //criando uma propriedade autoimplementada
            public double Preco { get; set; }

            /*a partir da propriedade acima posso
            criar uma propriedade também para leitura */
            public double PrecoComDesconto {

                get { return Preco - (desconto * Preco);}

            }
            
         }
        public static void Executar() {


        }
    }
}
