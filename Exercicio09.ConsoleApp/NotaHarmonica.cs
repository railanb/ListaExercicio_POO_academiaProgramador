using System;

namespace Exercicio09.ConsoleApp;

public class NotaHarmonica
{
    public decimal nota1;
    public decimal nota2;
    public decimal nota3;
    public decimal nota4;
    
    public decimal ObterMediaHarmonica()
    {
        decimal mediaHamonica = (4 / (
            (1 / nota1) + 
            (1 / nota2) + 
            (1 / nota3) + 
            (1 / nota4) 
        ));

        return mediaHamonica;
    }
}
