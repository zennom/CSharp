using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    public class Comida {
        public double Peso;

        public Comida(double peso) {
            Peso = peso;
        }
        public Comida() {}
    }
    public class Feijao : Comida {
       
    }
    public class Arroz : Comida {
        
    }
   public class Carne : Comida {
        
    }
    public class Pessoa {
        public double Peso;
        /* agora aqui ao invés de termos 3 métodos
         * um pra cada tipo de comida, a gente cria
         * apenas um em que vai ter as informações das
         * 3 comidas
         public void Comer(Feijao feijao) { 
            Peso += feijao.Peso;
        }
        public void Comer(Arroz arroz) {
            Peso += arroz.Peso;
        }
        public void Comer(Carne carne) {
            Peso += carne.Peso;
        } */

        public void Comer (Comida comida) {
            Peso += comida.Peso;
        }
    }
    internal class Polimorfismo {
        public static void Executar() {
            Feijao ingrediente1 = new Feijao();
            ingrediente1.Peso = 0.3;

            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.25;

            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.30;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 80.2;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine($"Agora o peso do cliente é {cliente.Peso} kg!");
        }
    }
}
