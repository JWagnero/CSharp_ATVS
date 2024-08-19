/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
•   Contextualização: Em um jogo de RPG, o jogador precisa inserir as informações básicas do
    personagem antes de começar a aventura.
•   Comando: Crie um programa que receba o nome, idade, nível inicial, classe, e raça do
    personagem e exiba esses dados no console.

@Lista: 01 - Lógica de Programação
@Autor: João Wagner
@Data: 19/08/2024
---------------------------------------------------------------------*/

using System;

class Program 
{
    static void Main()
    {
        string? nome, idade, nivel, classe, raça;

        Console.WriteLine("Diga o nome do personagem");
        nome = Console.ReadLine();

        Console.WriteLine("Diga a idade do personagem");
        idade = Console.ReadLine();

        Console.WriteLine("Diga o nivel do personagem");
        nivel = Console.ReadLine();

        Console.WriteLine("Diga a classe do personagem");
        classe = Console.ReadLine();

        Console.WriteLine("Diga a raça do personagem");
        raça = Console.ReadLine();
        
        System.Console.WriteLine($"\nNome do personagem:      {nome}");
        System.Console.WriteLine($"\nA idade do personagem:   {idade}");
        System.Console.WriteLine($"\nO nivel do personagem:   {nivel}");
        System.Console.WriteLine($"\nClasse do personagem:    {classe}");
        System.Console.WriteLine($"\nA raça do personagem:  {raça} ");

        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
        
    }
}