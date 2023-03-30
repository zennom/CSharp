using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class ExerciciosOperadores {
        public static void Executar() {

            Console.Write("Digite a primeira nota:");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota:");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota:");
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"A média do aluno é de : {media.ToString("F1")}");

        }
    }
}
