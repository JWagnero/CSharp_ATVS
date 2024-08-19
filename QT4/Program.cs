/*-------------------------------------------------------------------
Questão 4: Somatório de Moedas
•   Contextualização: No seu jogo, o jogador coleta moedas durante uma fase. A cada coleta, o total
    de moedas aumenta.
•   Comando: Desenvolva um programa que receba

@Lista: 01 - Lógica de Programação
@Autor: João Wagner
@Data: 19/08/2024
---------------------------------------------------------------------*/
using System;

class Program 
{
    static void Main()
    {
        int moeda1, moeda2, moeda3, moeda4, moeda5, moedasTotais;


        Console.WriteLine("Quantos moedas 1 você pegou?");
        int.TryParse(Console.ReadLine(), out moeda1);
        Console.WriteLine("Quantas moedas 2 você pegou?");
        int.TryParse(Console.ReadLine(), out moeda2);
        Console.WriteLine("Quantas moedas 3 você pegou?");
        int.TryParse(Console.ReadLine(), out moeda3);
        Console.WriteLine("Quantas moedas 4 você pegou?");
        int.TryParse(Console.ReadLine(), out moeda4);
        Console.WriteLine("Quantas moedas 5 você pegou?");
        int.TryParse(Console.ReadLine(), out moeda5);

        // moeda1 x moeda2 x moeda4 x moeda5 + moeda3
        moedasTotais = moeda1 + moeda2 + moeda4 + moeda5 + moeda3;

    System.Console.WriteLine($"a pontuação final é de: {moedasTotais}");



        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
        
    }
}