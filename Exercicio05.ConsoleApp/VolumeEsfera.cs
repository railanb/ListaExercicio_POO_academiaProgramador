using System;

namespace Exercicio05.ConsoleApp;

public class VolumeEsfera
{
    public decimal raio;
    public decimal pi;

    public decimal ObterVolume()
    {
        decimal raioCubo = raio * raio * raio;
        decimal volumeFormula = 4 * (raioCubo / 3);
        decimal volume = volumeFormula * pi;

        return volume;
    }

}
