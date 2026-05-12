using Exercicio10.ConsoleApp;

calculandoMedia media = new calculandoMedia();
media.nota1 = 8;
media.nota2 = 9;
media.peso1 = 6;
media.peso2 = 6;


Console.Clear();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("╔══════════════════════════════╗");
Console.WriteLine("║ CALCULANDO A MEDIA PONDERADA ║");
Console.WriteLine("╚══════════════════════════════╝");



decimal mediaPonderada = media.ObterMedia();

Console.WriteLine($"=> A media ponderada do aluno é : {mediaPonderada:F2}");

Console.ResetColor();