using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Executar() {

            //o var interpreta a variavel que você criou de acordo com
            //o tipo dela, se você colocou aspas ele vai entender que é uma string
            //se você colocou número ele entende que é inteiro e se colocou
            //numero com decimal ele entende que é double
            var nome = "Viviane";

            /*

            string nome = "Zézinho";
            int idade = 28;
            double altura = 1.65;
            bool temGato = false;

            Console.WriteLine($"Olá, meu nome é {nome} e eu tenho {idade} anos e {altura} de altura");

            double raio = 4.5;
            const double pi = 3.14;
            double area = pi * raio * raio;

            Console.WriteLine("A área total é:"+area);
            */
        }
    }
}
