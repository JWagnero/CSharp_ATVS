/*-------------------------------------------------------------------
Atividade 9: Comparação de Poder de Ataque
•   Contextualização: Em um jogo de luta, cada personagem tem um valor de ataque baseado em 
    sua força, arma e bônus de habilidades. O total de ataque é afetado por modificadores críticos 
    e pelo tipo da arma.
•   Crie um programa que receba o valor da força do personagem, o poder da arma, o bônus de 
    Comando: habilidades, um modificador de crítico, e um modificador para o tipo da arma. O 
    programa deve calcular o total de ataque do personagem



@Lista: 01 - Lógica de Programação
@Autor: joão Wagner
@Data: 20/08/2024
---------------------------------------------------------------------*/
class Program 
{
    static void Main()
    {
        double fc, poder_arma, bonusHab, modCRT, modArma, atq_Total;


        Console.WriteLine("Quanto de força você tem?");
        double.TryParse(Console.ReadLine(), out fc);
        Console.WriteLine("Quanto de poder de arma você tem?");
        double.TryParse(Console.ReadLine(), out poder_arma);
        Console.WriteLine("Quanto de bonus habilidade  você tem?");
        double.TryParse(Console.ReadLine(), out bonusHab);
        Console.WriteLine("Qual o modificador de crititco?");
        double.TryParse(Console.ReadLine(), out modCRT);
        Console.WriteLine("Qual o midificador de habilidade?");
        double.TryParse(Console.ReadLine(), out modArma);

        // fc x poder_arma x modCRT x modArma + bonusHab
        atq_Total = fc + poder_arma * (bonusHab * modCRT * modArma);


    System.Console.WriteLine($"Seu ataque total foi de : {atq_Total}");



        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
        
    }
}