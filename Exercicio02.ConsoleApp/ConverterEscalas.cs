using System;

namespace Exercicio02.ConsoleApp;

public class ConverterEscalas
{
    public decimal temperatura;

    public decimal ObterFahrenheit()
    {

        //
        decimal fahrenheit = (temperatura * 1.8m) + 32;
        return fahrenheit;
    }
}
