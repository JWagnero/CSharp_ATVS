/*-------------------------------------------------------------------
Atividade 7: Experiência e Nível do Jogador após Batalha
•   Contextualização: Em um jogo, o jogador enfrenta dois tipos diferentes de xp_acumulado em uma 
    batalha. Cada tipo de inimigo concede uma quantidade específica de XP. Após a batalha, o 
    jogador ganha esse XP e precisa somá-lo ao XP total acumulado para determinar o nível atual 
    do personagem.
•   Comando:Desenvolva um programa que receba a quantidade de XP acumulado, o XP concedido 
    pelo primeiro tipo de inimigo, o XP concedido pelo segundo tipo de inimigo, o número de cada 
    tipo de inimigo derrotado, e a constante de nível. O programa deve calcular o XP total 
    acumulado após a batalha e determinar o nível atual do jogador.

@Lista: 01 - Lógica de Programação
@Autor: joão Wagner
@Data: 20/08/2024
---------------------------------------------------------------------*/
class Program 
{
    static void Main()
    {
        int xp_acumulado, xp_inimigo1, tipo1_derrotado, xp_inimigo2, tipo2_derrotado, xptotal, nivel;


        Console.WriteLine("Quantos de xp acumulado você tem?");
        int.TryParse(Console.ReadLine(), out xp_acumulado);
        Console.WriteLine("Quantos voce ganhou de xp apos matar inimigos 1?");
        int.TryParse(Console.ReadLine(), out xp_inimigo1);
        Console.WriteLine("Quantos tipos 1 de inimigo voce matou?");
        int.TryParse(Console.ReadLine(), out tipo1_derrotado);
        Console.WriteLine("Quantos voce ganhou de xp apos matar inimigos 2?");
        int.TryParse(Console.ReadLine(), out xp_inimigo2);
        Console.WriteLine("Quantos tipos 2 de inimigo voce matou?");
        int.TryParse(Console.ReadLine(), out tipo2_derrotado);

        // xp_acumulado x xp_inimigo1 x xp_inimigo2 x tipo2_derrotado + tipo1_derrotado
        xptotal = xp_acumulado + (xp_inimigo1 * tipo1_derrotado) + (xp_inimigo2 *tipo2_derrotado);

        nivel = xptotal / 100;

    System.Console.WriteLine($"o seu xp total é: {xptotal} e seu nivel total é lv{nivel}");



        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
        
    }
}