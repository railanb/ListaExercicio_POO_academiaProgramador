using Exercicio08.ConsoleApp;

calculandoVolume volLata = new calculandoVolume();
volLata.pi = (decimal)Math.PI;
volLata.raio = 3;
volLata.altura = 3;

Console.Clear();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("╔═══════════════════╗");
Console.WriteLine("║ CALCULANDO VOLUME ║");
Console.WriteLine("╚═══════════════════╝");



decimal volumeLata = volLata.ObterVolume();

Console.WriteLine($"=> O volume da lata de oleo é: {volumeLata:F2}");

Console.ResetColor();