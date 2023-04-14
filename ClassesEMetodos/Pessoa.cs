using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Pessoa {

        /*estamos colocando o tipo "public"
        porque quero que esse atributo fique visível
        para a minha classe , imagine que na vida real
        temos alguns atributos que precisam ser publicos 
        e outros que precisamos esconder das outras pessoas */

        public string Nome;
        public int Idade;

        /*não colocamos nenhum valor padrão porém, 
        string tem valor padrão null e int
        tem valor padrão zero */
    }
}
