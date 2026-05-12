using System;

namespace Exercicio03.ConsoleApp;

public class volumeCilindro
{
    public decimal raio;
    public decimal altura;
    public decimal pi;

    public decimal ObterVolumeCilindro()
    {
        decimal areaRaio = (raio * raio) * pi;
        decimal volCilindro = areaRaio * altura;

        return volCilindro;
    }
}
