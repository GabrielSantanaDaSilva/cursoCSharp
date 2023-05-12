using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;

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
                {"Estrutura If - Estrutura de Controle", EstruturaIf.Executar }
            });


            central.SelecionarEExecutar();
        }
    }
}