using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Arrays {

        public static void Executar() {

            string[] alunos = new string[5];
            alunos[0] = "José";
            alunos[1] = "Cleiton";
            alunos[2] = "Amanda";
            alunos[3] = "Vitória";
            alunos[4] = "Cilano";

            foreach(var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            //MÉDIA COM ARRAYS
            double somatorio = 0;
            double[] notas = { 9.5, 6.7, 8.4, 5.9};

            foreach(var nota  in notas) {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;
            Console.WriteLine(media.ToString("#.##"));

        }
    }
}
