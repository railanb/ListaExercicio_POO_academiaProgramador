// Crie um programa para calcular o volume de uma caixa retangular
// COMPRIMENTO * LARGURA * ALTURA.

using Exercicio01.ConsoleApp;

CaixaRetangular caixa = new CaixaRetangular();
caixa.altura = 60;
caixa.largura = 50;
caixa.comprimento = 80;

Console.Clear();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("╔════════════════════════════╗");
Console.WriteLine("║   CALCULADORA DE VOLUME    ║");
Console.WriteLine("╚════════════════════════════╝");


decimal volumeCaixa =  caixa.ObrterVolume();
Console.WriteLine($"=> O volume do seu retangulo: {volumeCaixa:F2} cm³");

Console.ResetColor();

Console.ReadLine();