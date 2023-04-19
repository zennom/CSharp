using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b;
        }
        public int Subtrair(int a, int b) {
            return a - b;
        }
        public int Multiplicar(int a, int b) {
            return a * b;
        }
    }
    internal class MetodosComRetorno {
        public static void Executar() {

            /*aqui dentro vamos instanciar o objeto calculadoraComum */
            var calculadoraComum = new CalculadoraComum();

            /* após fazer a instancia eu consigo chamar as funções*/
            var resultado = calculadoraComum.Somar(5, 5);
            Console.WriteLine(resultado);

            //podemos também chamar a função diretamente do console
            Console.WriteLine(calculadoraComum.Subtrair(15,10));


        }
    }
}

