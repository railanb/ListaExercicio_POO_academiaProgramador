/*
Crie um programa para calcular o consumo de combustível por Km. 
Deverá ser informado a kilometragem Inicial e Final do Percurso do Veículo. 
Deverá ser informado o Consumo de Combustível 

*/
using Exercicio04.ConsoleApp;

CalcularConsumo consumo = new CalcularConsumo();
consumo.kmInicial = 75;
consumo.kmFinal = 184;
consumo.combustivel = 15;


Console.Clear();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("╔═══════════════════════════╗");
Console.WriteLine("║ SEU CONSUMO EM SUA VIAGEM ║");
Console.WriteLine("╚═══════════════════════════╝");

decimal consumoMedia = consumo.ObterConsumo();

Console.Write($"Seu consumo foi de {consumoMedia:F2} km/l");

Console.ResetColor();
Console.ReadLine();