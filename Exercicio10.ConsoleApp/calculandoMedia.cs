using System;

namespace Exercicio10.ConsoleApp;

public class calculandoMedia
{
    public decimal nota1;
    public decimal nota2;
    public decimal peso1;
    public decimal peso2;

    public decimal ObterMedia()
    {
        
        decimal mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

        return mediaPonderada;
    }

}
