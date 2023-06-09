﻿using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.MetodosEFuncoes;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {

            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variáveis e Constantes - Fundamentos",VariaveisEConstantes.Executar},
                {"Notação Ponto - Fundamentos",NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos",LendoDados.Executar},
                {"Formatando Números - Fundamentos",FormatandoNumeros.Executar},
                {"Operadores Aritméticos - Exercícios ",OperadoresAritmeticos.Executar},
                {"Exercícios Operadores",ExerciciosOperadores.Executar},
                {"Operadores Lógicos e Relacionais",OperadoresLogicosERelacionais.Executar},
                {"Operadores de Atribuição",OperadoresAtribuicao.Executar},

                //Esruturas de Controle
                {"Estrutura If - Estruturas de Controle",EstruturaIf.Executar },
                {"Estrutura If Else -Estruturas de Controle",EstruturaIfElse.Executar },
                {"Exercícios If Else -Estruturas de Controle",ExerciciosIfElse.Executar },
                {"Estrutura Switch -Estruturas de Controle",EstruturaSwitch.Executar },
                {"Estrutura While - Estruturas de Controle",EstruturaWhile.Executar},
                {"Estrutura For - Estruturas de Controle",EstruturaFor.Executar},
                {"Estrutura ForEach - Estruturas de Controle",EstruturaForEach.Executar},

                //Classes e Métodos
                {"Membros - Classes e Métodos",Membros.Executar },
                {"Construtores - Classes e Métodos",Construtores.Executar },
                {"Métodos Com Retorno - Classes e Métodos",MetodosComRetorno.Executar },
                {"Métodos Com Retorno - Exericios ",ExercicioMetodosComRetorno.Executar },
                {"Métodos Estáticos - Classes e Métodos",MetodosEstaticos.Executar },
                {"Params - Classes e Métodos",Params.Executar },
                {"Get e Set - Classes e Métodos",GetSet.Executar},
                {"Get e Set  Segundo Exemplo - Classes e Métodos",GetESetSegundoExemplo.Executar},
                {"Exercícios - Entregar",ExercicioEntregar.Executar},
                {"Exercícios - Classes e Métodos",ExerciciosGetESet.Executar},

                //Coleções
                {"Array - Coleções",Arrays.Executar},
                {"Queue - Coleções",ColecoesQueue.Executar},
                {"Stack - Coleções",ColecoesStack.Executar},

                //Orientação a Objetos
                {"Herança - OO",Heranca.Executar},
                {"Construtor This - OO ",ConstrutorThis.Executar},
                {"Encapsulamento - OO",OO.Encapsulamento.Executar},
                {"Polimorfismo - OO",Polimorfismo.Executar},
                {"Abstract - OO ",Abstract.Executar},
                {"Sealed - OO",Sealed.Executar},

                //Métodos e Funções
                {"Exemplo Lambda - Métodos e Funções",ExemploLambda.Executar},
                {"Lambda Delegate - Métodos e Funções",LambdasDelegate.Executar},
                {"Polimorfismo - Exercício Polimorfismo",ExercicioPolimorfismo.Executar}


            });

            central.SelecionarEExecutar();
        }
    }
}