/*-------------------------------------------------------------------
Questão 3: Cálculo de Vida Restante
* Contextualização: Durante um combate, o jogador recebe dano e a vida do personagem
  diminui.
* Comando: Crie um programa que receba o valor da vida inicial, o dano recebido, o bônus de
  regeneração, do atacado, e dois modificadores, do atacante, (um para equipamentos e outro
  para habilidades), e calcule a vida restante.

@Lista: 01 - Lógica de Programação
@Autor: João Wagner
@Data: 19/08/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) 
    {
        double vidaIni, danoRece, bonusRegen, modE, modHab, vidaRest;


        Console.Write("Quanto life você tem: ");
        double.TryParse(Console.ReadLine(), out vidaIni);
        Console.WriteLine("Quantos de dano levou?");
        double.TryParse(Console.ReadLine(), out danoRece);
        Console.WriteLine("Qual o bonus da sua regen?");
        double.TryParse(Console.ReadLine(), out bonusRegen);
        Console.WriteLine("Qual o modificador de equipamento?");
        double.TryParse(Console.ReadLine(), out modE);
        Console.WriteLine("Qual o modificador de habilidade?");
        double.TryParse(Console.ReadLine(), out modHab);

        // vidaIni - (dano)
        vidaRest = (vidaIni - (danoRece * modE * modHab)) + bonusRegen;

    System.Console.WriteLine($"a vida restante é de: {vidaRest}");


        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}