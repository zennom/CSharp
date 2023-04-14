using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class ExerciciosOperadores {
        public static void Executar() {

            Console.WriteLine("Digite a distância  percorrida em KM:");
            int distancia = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o totla de combustível gasto: ");
            double combustivel = double.Parse(Console.ReadLine());

            double resultado = distancia / combustivel;


            Console.WriteLine(resultado.ToString("##.###"), "km/l");


            /*
             * 
             *  Console.Write("Digite o seu número de funcionário:");
            var numFunc = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de horas trabalhadas:");
            var horasTrab = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor que você recebe por hora:");
            var valorHora = double.Parse(Console.ReadLine());


            double salario = horasTrab * valorHora;

            Console.WriteLine($"Número de funcionário {numFunc} Salário: R$ {salario.ToString("#,###")}");
            
            Console.Write("Digite a primeira nota:");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota:");
            double nota2 = double.Parse(Console.ReadLine());


            double media = (nota1 * 3.5 + nota2 * 7.5) / 11;

            Console.WriteLine($"A média do aluno é de : {media.ToString("F1")}");

            Console.Write("Digite a primeira nota:");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota:");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota:");
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"A média do aluno é de : {media.ToString("F1")}");

            */

        }
    }
}
