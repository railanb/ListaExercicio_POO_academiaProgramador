using System;
using System.Text;

namespace Exercicio07.ConsoleApp;

public class calculandoComissao
{
    public decimal baseSalario;
    public decimal valorVendas;
    public decimal comissaoPercentual;

    public decimal ObterPorcentagem()
    {
        decimal porcentagem = comissaoPercentual / 100;
        return porcentagem;
    }

    public decimal ObterSalario()
    {
        decimal salario = valorVendas * ObterPorcentagem();
        decimal salarioTotal = salario + baseSalario;

        return salarioTotal;
        
   }

}
