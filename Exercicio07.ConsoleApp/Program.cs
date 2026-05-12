using Exercicio07.ConsoleApp;

calculandoComissao comissao = new calculandoComissao();
comissao.baseSalario = 2600;
comissao.valorVendas = 1450;
comissao.comissaoPercentual = 2;


//Console.Clear();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("╔═══════════════════════════════════════════╗");
Console.WriteLine("║ CALCULANDO O SALARIO TOTAL DE UM VENDEDOR ║");
Console.WriteLine("╚═══════════════════════════════════════════╝");


decimal salarioTotal = comissao.ObterSalario();

Console.WriteLine($"=> O SALARIO DO VENDEDOR FOI DE R$ {salarioTotal:F2}");

Console.ResetColor();
