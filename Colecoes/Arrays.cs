using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Arrays {

        public static void Executar() {

            string[] alunos = new string[5];
            /*um array de 5 posições terá 4 valores
            pois contamos o 0  para acessar a posição específica é só por 
            a posição dentro de colchetes */

            alunos[0] = "José";
            alunos[1] = "Cleiton";
            alunos[2] = "Amanda";
            alunos[3] = "Vitória";
            alunos[4] = "Cilano";

            //para percorrermos e exibirmos o array, usamos foreach
            foreach(var aluno in alunos) {
                Console.WriteLine(aluno);
            }

        }
    }
}
