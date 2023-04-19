using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Conversao {

        public double converterRealDolar(double real) {
            return real / 5.20;
        }

        public double converterCelsius(double celsius) {
            return celsius * 1.8 + 32;
        }
    }
    internal class ExercicioMetodosComRetorno {
        public static void Executar() {
            //instanciando o objeto
            var Calculos = new Conversao();
            //perguntando ao usuário
            Console.WriteLine("Digite o valor em reais para converter: ");
            double.TryParse(Console.ReadLine(), out double real);
            //chamando a função e mostrando resultado
            var resultado = Calculos.converterRealDolar(real);
            Console.WriteLine($"O valor em reais é de R$: {resultado.ToString("F1")}");
            //perguntando ao usuário
            Console.WriteLine("Digite a temperatura em gruas celsius para converter: ");
            double.TryParse(Console.ReadLine(), out double celsius);
            //chamando a função e mostrando resultado
            var resultado2 = Calculos.converterCelsius(celsius);
            Console.WriteLine($"A temperatura em Fahrenheit é de: {resultado2.ToString("##.#")}");
        }

    }
}
