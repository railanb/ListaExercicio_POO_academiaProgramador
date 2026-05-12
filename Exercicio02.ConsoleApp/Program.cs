using Exercicio02.ConsoleApp;

ConverterEscalas escalas = new ConverterEscalas();
escalas.temperatura = 20;


Console.Clear();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("╔═══════════════════════════════════════════════════════════╗");
Console.WriteLine("║ CALCULANDO A ESCALA DE CELSIUS PARA FAHRENHEIT (20 ºC)    ║");
Console.WriteLine("╚═══════════════════════════════════════════════════════════╝");

decimal fahrenheitResul = escalas.ObterFahrenheit();

Console.WriteLine($"=> Agora esta {fahrenheitResul:F2}ºF");

Console.ResetColor();

Console.ReadLine();