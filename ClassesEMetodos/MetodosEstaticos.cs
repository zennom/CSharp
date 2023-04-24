using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public class CalculadoraEstatica{
        public int Somar(int a, int b) {
            return a + b;
        }
        public static int Multiplicar(int a, int b) {

            return a * b;
        }
    }
    internal class MetodosEstaticos {
        public static void Executar() {
            //aqui vamos chamar o nosso método multiplicar e Somar
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine(resultado);

            //Console.WriteLine(CalculadoraEstatica.Somar(10, 10));


            /*fazendo a instância de somar
            a partir do momento em que eu tenho uma instância
            de CalculadoraEstatica */
            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(10,10));
        }
    }
}
