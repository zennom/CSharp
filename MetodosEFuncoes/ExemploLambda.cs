using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {
    internal class ExemploLambda {

        public static void Executar() {

            Action algoNoConsole = () => {
                Console.WriteLine("Lambda com C#");
            };
            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };
            Console.WriteLine(jogarDado());
            Func<int, string> conversoHex = numero => {
                return numero.ToString("x");
            };

            Console.WriteLine(conversoHex(1234));
            //criando uma nova função
            Func<int, int, int, string> formatarData = (dia, mes, ano) => {
                return string.Format("{0:D2} /{1:D2} / {2:D2}",dia,mes,ano);
            };

            //chamando a função
            Console.WriteLine(formatarData(02, 06, 1995));
        }
    }
}
