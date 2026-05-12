using System;

namespace Exercicio06.ConsoleApp;

public class ConverterEscala
{
    public decimal temperatura;

    public decimal ObterCelsius()
    {

        //
        decimal celsius = (temperatura - 32) / 1.8m;
        return celsius;
    }
}