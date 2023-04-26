using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CursoCSharp.ClassesEMetodos {
    internal class ExerciciosGetESet {
        public class Aluno {

            private double n1, n2, n3;
            public double Media {
                get { return (n1 + n2 + n3) / 3; }
                set { n1 = value; n2 = value; n3 = value; }
            }
            public Aluno(double n1, double n2, double n3) {
                this.n1 = n1;
                this.n2 = n2;
                this.n3 = n3;
            }
        }

        public static void Executar() {
            var aluno1 = new Aluno(3.5,7.8,9.0);
            Console.WriteLine(aluno1.Media.ToString("#.##"));
        }
    }
}
