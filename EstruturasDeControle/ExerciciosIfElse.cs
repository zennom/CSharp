using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CursoCSharp.EstruturasDeControle {
    internal class ExerciciosIfElse {
        public static void Executar() {

            Console.Write("Digite o ano em que você nasceu: ");
            int ano = int.Parse(Console.ReadLine());

            int anoAtual = 2023;

            int idade = anoAtual - ano;

            if (idade >= 18 && idade <= 70) {
                Console.WriteLine($"Você tem {idade} anos, você pode votar ");
            } else {
                Console.WriteLine($"Você tem {idade} anos, você não precisa votar");
            }

        }
    }
}
