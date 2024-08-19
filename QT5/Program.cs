/*-------------------------------------------------------------------
Questão 5: Cálculo de Distância Percorrida
•   Contextualização: Um veículo no jogo percorre uma certa distância em um tempo determinado.
•   Comando: Crie um programa que receba a velocidade do veículo, o tempo de viagem e dois
    multiplicadores (um para condições climáticas e outro para estado do veículo), e calcule a
    distância total percorrida.

@Lista: 01 - Lógica de Programação
@Autor: joão Wagner
@Data: 19/08/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) 
    {
        double velocidade, tempo, multClima, multEstadoVei, distanciaPer;

        System.Console.WriteLine("Qual a velocidade do veiculo?");
        double.TryParse(Console.ReadLine(), out velocidade);
        System.Console.WriteLine("Qual o tempo?");
        double.TryParse(Console.ReadLine(), out tempo);
        System.Console.WriteLine("Qual o multiplicador climatico?");
        double.TryParse(Console.ReadLine(), out multClima);
        System.Console.WriteLine("Qual o estado do veiculo");
        double.TryParse(Console.ReadLine(), out multEstadoVei);

        distanciaPer = velocidade * tempo * multClima * multEstadoVei; 

        System.Console.WriteLine($"A distancia percorrida é de: {distanciaPer}");

        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}