using System;

namespace Exercicio08.ConsoleApp;

public class calculandoVolume
{
    public decimal raio;
    public decimal altura;
    public decimal pi;

    public decimal ObterVolume()
    {
        decimal volume = ((pi * raio) - (2 * altura));
        return volume;
    }
}
