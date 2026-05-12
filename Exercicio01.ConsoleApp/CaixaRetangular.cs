using System;

namespace Exercicio01.ConsoleApp;

public class CaixaRetangular
{
    public decimal comprimento;
    public decimal largura;
    public decimal altura;

    public decimal ObrterVolume()
    {
        decimal volume = comprimento * altura * largura;
        return volume;
    }

}
