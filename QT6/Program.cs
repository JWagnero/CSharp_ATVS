/*-------------------------------------------------------------------
Questão 6: Conversão de Moeda do Jogo
•   Contextualização: O jogo possui uma loja onde os jogadores podem trocar moedas de ouro por
    cristais.
•   Comando: Desenvolva um programa que receba o valor de moedas de ouro, o valor da taxa de
    conversão (1 cristal = X moedas de ouro), e dois bônus de conversão (um baseado em eventos
    e outro em habilidades), e calcule o número de cristais que o jogador pode obter.

@Lista: 01 - Lógica de Programação
@Autor: joão Wagner
@Data: 20/08/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) 
    {
        double moedasOuro, taxade, bonusEvento, bonusHab, cristaisW; 

        System.Console.WriteLine("Quantos moedas você ganhou?");
        double.TryParse(Console.ReadLine(), out moedasOuro);
        System.Console.WriteLine("Qual a taxa de conversão?");
        double.TryParse(Console.ReadLine(), out taxade);
        System.Console.WriteLine("Qual o bonus de evento?");
        double.TryParse(Console.ReadLine(), out bonusEvento);
        System.Console.WriteLine("Qual o bonus de habilidade?");
        double.TryParse(Console.ReadLine(), out bonusHab);

        cristaisW =  moedasOuro / taxade * bonusEvento * bonusHab;

        System.Console.WriteLine($"o seus cristais ganhos são: {cristaisW}");

        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}