/*

Raio: 3 metros
Altura: 10 metros
Área da base: 3.14 * 3² = 28,26$ m²
Volume: 28,26 x 10 = 282,6m³

*/

using Exercicio03.ConsoleApp;

volumeCilindro cilindro = new volumeCilindro();
cilindro.altura = 10;
cilindro.raio = 3;
cilindro.pi = (decimal)Math.PI;

Console.Clear();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("╔════════════════════════════════════════════════════╗");
Console.WriteLine("║ VOLUME DO SEU CILINDRO => RAIO = 3M | ALTURA = 10M ║");
Console.WriteLine("╚════════════════════════════════════════════════════╝");

decimal cilindroVolume = cilindro.ObterVolumeCilindro();

Console.Write($"=> O volume do cilindro é {cilindroVolume:F2} m³");

Console.ResetColor();
Console.ReadLine();