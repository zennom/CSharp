using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class FormatandoNumeros {
        public static void Executar() {
            //ARREDONDANDO NÚMERO
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            //TRANSFORMAR EM UM VALOR MONETÁRIO (MOEDA DE ACORDO COM IDIOMA DA SUA MÁQUINA)
            Console.WriteLine(valor.ToString("C"));
            //MULTIPLICA UM VALOR POR 100 E ADICIONA PERCENTUAL
            Console.WriteLine(valor.ToString("P"));
            //FORMATANDO O NÚMERO DO JEITO QUE VOCÊ QUISER
            Console.WriteLine(valor.ToString("#.##"));
        }
    }
}
