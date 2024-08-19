/*-------------------------------------------------------------------
Questão 2: Pontuação Final
•   Contextualização: No final de uma missão em um jogo, a pontuação do jogador é calculada com
    base nos inimigos derrotados e pontos adicionais.
•   Comando: Desenvolva um programa que receba o número de inimigos derrotados, a pontuação
    por inimigo, bônus por missão, e dois multiplicadores (um para tipo de inimigo e outro para
    dificuldade), e então calcule e exiba a pontuação final.

@Lista: 01 - Lógica de Programação
@Autor: João Wagner
@Data: 19/08/2024
---------------------------------------------------------------------*/


using System;

class Program 
{
    static void Main()
    {
        int inimigos, pontos_Ini, bonus_Miss, mult_Ini, mult_Dif, pont_Final;


        Console.WriteLine("Quantos inimigos derrotados?");
        int.TryParse(Console.ReadLine(), out inimigos);
        Console.WriteLine("Quantos pontos por inimigos derrotados?");
        int.TryParse(Console.ReadLine(), out pontos_Ini);
        Console.WriteLine("Qual o bonus da missão?");
        int.TryParse(Console.ReadLine(), out bonus_Miss);
        Console.WriteLine("Quantos qual o tipo do inimigo?");
        int.TryParse(Console.ReadLine(), out mult_Ini);
        Console.WriteLine("Qual a dificuldade dos inimigos?");
        int.TryParse(Console.ReadLine(), out mult_Dif);

        // inimigos x pontos_Ini x mult_Ini x mult_Dif + bonus_Miss
        pont_Final = inimigos * pontos_Ini * mult_Ini * mult_Dif + bonus_Miss;

    System.Console.WriteLine($"a pontuação final é de: {pont_Final}");



        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
        
    }
}