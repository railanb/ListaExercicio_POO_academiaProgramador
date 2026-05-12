using System;

namespace Exercicio04.ConsoleApp;

public class CalcularConsumo
{
    public decimal kmInicial;
    public decimal kmFinal;
    public decimal combustivel;

    public decimal ObterConsumo()
    {
        decimal consumoMedia = (kmFinal - kmInicial) / combustivel;
        return consumoMedia;
    }
}
