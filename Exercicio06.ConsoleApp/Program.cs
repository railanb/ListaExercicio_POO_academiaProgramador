using Exercicio06.ConsoleApp;

ConverterEscala escalas = new ConverterEscala();
escalas.temperatura = 80;


Console.Clear();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("╔═══════════════════════════════════════════════════════════╗");
Console.WriteLine("║ CALCULANDO A ESCALA DE CELSIUS PARA FAHRENHEIT (80 ºF)    ║");
Console.WriteLine("╚═══════════════════════════════════════════════════════════╝");

decimal celsiusResul = escalas.ObterCelsius();

Console.WriteLine($"=> Agora esta {celsiusResul:F2}ºC");

Console.ResetColor();

Console.ReadLine();Console.WriteLine("Hello, World!");
