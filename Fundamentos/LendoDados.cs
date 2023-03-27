using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class LendoDados {
        public static void Executar() {
            //vamos perguntar ao usuário qual é o nome dele
            Console.Write("Qual é o seu nome? ");
            //esse resultado será armazenado em uma variável
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            /*por padrão o C# recebe todas as variaveis como string
            então precisamos converter ela para inteiro ou real */
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual sua altura? ");
            double altura= double.Parse(Console.ReadLine());

            Console.WriteLine($"{nome} {idade} {altura}");
        }
    }
}
