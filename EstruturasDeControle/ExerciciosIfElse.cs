using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CursoCSharp.EstruturasDeControle {
    internal class ExerciciosIfElse {
        public static void Executar() {

            Console.WriteLine("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso:");
            double peso = double.Parse(Console.ReadLine());

            double imc = (peso / (altura * altura));

            if(imc < 18) {
                Console.WriteLine($"Seu imc é {imc.ToString("#.#")} e você está abaixo do peso");
            } else if(imc > 18.5 && imc <= 24.9) {
                Console.WriteLine($"Seu imc é {imc.ToString("#.#")} e você está no peso ideal");
            } else if (imc > 24.9 && imc <= 29.9 ) {
                Console.WriteLine($"Seu imc é {imc.ToString("#.#")} e você está acima do peso");
            } else if (imc > 29.9 && imc <= 34.9) {
                Console.WriteLine($"Seu imc é {imc.ToString("#.#")} e você está com obesidade grau I");
            } else if ( imc > 34.9 && imc <= 39.9) {
                Console.WriteLine($"Seu imc é {imc.ToString("#.#")} e você está com obesidade grau II");
            } else {
                Console.WriteLine($"Seu imc é {imc.ToString("#.#")} e você está com obesidade grau III");
            }


                /*
                      Console.WriteLine("Digite a primeira nota:");
                double n1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a segunda nota:");
                double n2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a terceira nota:");
                double n3 = double.Parse(Console.ReadLine());

                double media = (n1 + n2 + n3) / 3;

                if(media > 7) {
                    Console.WriteLine($"Sua nota foi {media.ToString("#.##")} você foi aprovado!");
                } else if(media >= 5 && media < 7) {
                    Console.WriteLine($"Sua nota foi {media.ToString("#.##")} você está de recuperação!");
                } else {
                    Console.WriteLine($"Sua nota foi {media.ToString("#.##")} você está reprovado!");
                }



                    Console.Write("Digite a senha: ");
                string password = Console.ReadLine();

                if(password != "7taz9HvJ") {
                    Console.WriteLine("Acesso Negado");
                } else {
                    Console.WriteLine("Acesso Permitido");
                }


                Console.Write("Digite o ano em que você nasceu: ");
                int ano = int.Parse(Console.ReadLine());

                int anoAtual = 2023;

                int idade = anoAtual - ano;

                if (idade >= 18 && idade <= 70) {
                    Console.WriteLine($"Você tem {idade} anos, você pode votar ");
                } else {
                    Console.WriteLine($"Você tem {idade} anos, você não precisa votar");
                }
                */

        }
    }
}
