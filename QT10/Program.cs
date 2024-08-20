/*-------------------------------------------------------------------
Questão 10: Atualização de Pontos de Vida
•   Contextualização: Em um jogo de estratégia, um personagem pode ganhar pontos de vida a 
    cada nível alcançado.
•   Comando: Desenvolva um programa que receba os pontos de vida iniciais e o aumento de vida 
    por nível, e calcule a quantidade de pontos de vida após alcançar um novo nível.




@Lista: 01 - Lógica de Programação
@Autor: joão Wagner
@Data: 20/08/2024
---------------------------------------------------------------------*/
class Program 
{
    static void Main()
    {
        int vidaInicial, aumento_por_nivel, nivel_alcan, pontos_vidaT;


        Console.WriteLine("Quanto de vida inical você tem?");
        int.TryParse(Console.ReadLine(), out vidaInicial);
        Console.WriteLine("Qual o aumento por nivel?");
        int.TryParse(Console.ReadLine(), out aumento_por_nivel);
        Console.WriteLine("Qual seu nivel atual?");
        int.TryParse(Console.ReadLine(), out nivel_alcan);


        
        pontos_vidaT = vidaInicial + (aumento_por_nivel * nivel_alcan);


    System.Console.WriteLine($"Seu ataque total foi de : {pontos_vidaT}");



        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
        
    }
}