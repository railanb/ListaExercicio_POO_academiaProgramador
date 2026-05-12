
using Exercicio09.ConsoleApp;

NotaHarmonica notas = new NotaHarmonica();
notas.nota1 = 9;
notas.nota2 = 6;
notas.nota3 = 7;
notas.nota4 = 5;

Console.Clear();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("╔═════════════════════════════╗");
Console.WriteLine("║ CALCULANDO A NOTA HARMONICA ║");
Console.WriteLine("╚═════════════════════════════╝");



decimal mediaHamonica = notas.ObterMediaHarmonica();

Console.WriteLine($"=> A NOTA É: {mediaHamonica:F2}");

Console.ResetColor();