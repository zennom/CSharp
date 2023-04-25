using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Params {

        public static void Recepcionar(params string[] pessoas) {

            //aqui vamos usar o foreach para percorrer as pessoas
            foreach(var pessoa in pessoas) {
                Console.WriteLine($"Olá {pessoa}");  
            }
        }

        public static void Executar(){
            //chamando o método e os seus parâmetros
            Recepcionar("Naruto","Sasuke","Sakura","Kakashi");
        }
    }
}
