using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e constantes - Fundamentos",VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos",NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos" ,LendoDados.Executar },
                {"Formatando Números - Fundamentos",FormatandoNumeros.Executar },
                {"Operadores Aritiméticos - Fundamentos",OperadoresAritimeticos.Executar },
                {"Exercícios Da Aula - Fundamentos", ExerciciosAula.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                
                {"Estrutura If - Estrutura de Controle", EstruturaIf.Executar },
                {"Estrutura While e For - Estrutura de Controle", EstruturaWhileEFor.Executar },
                {"Estrutura Switch - Estrutura de Controle", EstruturaSwitch1.Executar },
                {"Exercicios de loop - Estrutura de Controle", ExerrciciosLoop.Executar },
                {"Estrutura For Each- Estrutura de Controle", EstruturaForEach.Executar },
                
                {"Membros - Classes de Métodos", Membros.Executar },
                {"Construtores - Classes de Métodos", Construtores.Executar },
                {"Métodos com Retorno - Classes de Métodos", MetodosComRetorno.Executar },
                {"Exercicio Metodos - Classes de Métodos", ExercicioMetodos.Executar },
                {"Param - Classes de Métodos", Params.Executar },
                {"Get e Set - Classes de Métodos", GetSet.Executar },
                {"Get e Set 2 - Classes de Métodos", GetESetSegundoExemplo.Executar },
                {"Get e Set Exercicio 1 - Classes de Métodos", Exercicio1GetSet.Executar },
                {"Get e Set Exercicio 2 - Classes de Métodos", Exercicio2GetSet.Executar },
                {"Get e Set Exercicio 3 - Classes de Métodos", Exercicio3GetSet.Executar },
            });


            central.SelecionarEExecutar();
        }
    }
}