using System;
using System.Threading.Channels;
using Encapsulamento;

namespace CursoCSharp.OO {
    public class FilhoNaoReconhecido : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("Filho não reconhecido...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoDeFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop);
        }
    }

    public class AmigoDistante {
        public readonly SubCelebridade amiga = new SubCelebridade();
        public new void MeusAcessos() {
            Console.WriteLine("Amigo distante...");
            // esse está acessível pois é atributo público
            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDosOlhos);
            //Console.WriteLine(amiga.NumeroDoCelular);
            //Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoDeFamilia);
            //Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }
    }
    internal class Encapsulamento {
        public static void Executar() {

            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();
            
            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();

        }
    }
}
