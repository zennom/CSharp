using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    public class Cliente {

        public string Nome;
        public string Tipo;

    }

    public class Fisico : Cliente {
        public string Cpf;
    }

    public class Juridico  : Cliente {
        public string Cnpj;
    }
    internal class ExercicioPolimorfismo {
        public static void Executar() {

            Fisico cliente1 = new Fisico();
            Juridico cliente2 = new Juridico();

            Console.WriteLine("Você é cliente físico ou jurídico?");
            cliente1.Tipo = Console.ReadLine();

            if (cliente1.Tipo == "fisico") {

                Console.WriteLine("Você é cliente físico, digite seu nome:");
                cliente1.Nome = Console.ReadLine();

                Console.WriteLine("Cliente físico digite seu CPF:");
                cliente1.Cpf = Console.ReadLine();
                
                Console.WriteLine($"Cliente físico {cliente1.Nome} CPF: {cliente1.Cpf}");
            } else {
                Console.WriteLine("Você é cliente jurídico, digite seu nome:");
                cliente1.Nome = Console.ReadLine();

                Console.WriteLine("Cliente Jurídico digite seu CNPJ:");
                cliente2.Cnpj = Console.ReadLine();
                Console.WriteLine($"Cliente físico {cliente2.Nome} CPF: {cliente2.Cnpj}");
            }
        }
    }
}
