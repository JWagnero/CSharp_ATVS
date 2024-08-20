/*-------------------------------------------------------------------
Questão 8: Cálculo de Pontos de Habilidade
•   Contextualização: Ao subir de nível, um jogador recebe pontos de habilidade que podem ser 
    distribuídos entre força, agilidade, inteligência e dois atributos adicionais.
•   Comando: Desenvolva um programa que receba a quantidade de pontos de habilidade 
    atribuídos a cada uma das cinco características e calcule o total de pontos distribuídos.


@Lista: 01 - Lógica de Programação
@Autor: joão Wagner
@Data: 20/08/2024
---------------------------------------------------------------------*/
class Program 
{
    static void Main()
    {
        int fc, agi, inte, dest, vita, pontosT;


        Console.WriteLine("Quanto de força você tem?");
        int.TryParse(Console.ReadLine(), out fc);
        Console.WriteLine("Quanto de agilidade você tem?");
        int.TryParse(Console.ReadLine(), out agi);
        Console.WriteLine("Quanto de inteligência você tem?");
        int.TryParse(Console.ReadLine(), out inte);
        Console.WriteLine("Quanto de destreza você tem?");
        int.TryParse(Console.ReadLine(), out dest);
        Console.WriteLine("Quanto de vitalidade você tem?");
        int.TryParse(Console.ReadLine(), out vita);

        // fc x agi x dest x vita + inte
        pontosT = fc + agi + inte + dest + vita;


    System.Console.WriteLine($"Seus pontos totais são: {pontosT}");



        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
        
    }
}