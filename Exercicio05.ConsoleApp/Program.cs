/*

*/
using Exercicio05.ConsoleApp;

VolumeEsfera esfera = new VolumeEsfera();
esfera.raio = 3;
esfera.pi = (decimal)Math.PI;

//Console.Clear();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("╔════════════════════╗");
Console.WriteLine("║ O VOLUME DE ESFERA ║");
Console.WriteLine("╚════════════════════╝");

decimal volume = esfera.ObterVolume();

Console.Write($"=> O volume é de {volume:F2}");

Console.ResetColor();
Console.ReadLine();