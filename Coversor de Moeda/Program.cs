using System.Globalization;
using Coversor_de_Moeda;
float resultadoFinal;
Volta:
Console.WriteLine($@"
-------------------------------------------
| Bem vindo ao Convertor de Moedas Vivi++ |
| Para iniciar selecione como você deseja |
| converter:                              |
|                                         |
|         [1] - Dólar em real             |
|         [2] - Real em Dólar             |
|         [0] - Sair                      |
|                                         |
-------------------------------------------
");
float resposta = float.Parse(Console.ReadLine()!);
switch (resposta)
{
    case 1:
    Console.WriteLine($"Insira o valor que deseja converter para Real:");
    float resultadoR = float.Parse(Console.ReadLine()!);
    resultadoFinal = Conversor.ConverterDolaremReal(resultadoR);
    Console.WriteLine($"{resultadoFinal:c2}");
    VoltaPerguntaP:
    Console.WriteLine($"Deseja voltar para o menu? s para sim e n para não");
    string validacao1 = Console.ReadLine()!;
    switch (validacao1)
    {
        case "s":
        goto Volta;
        case "n":
        break;
        default:
        Console.WriteLine($"Insira algo valido");
        goto VoltaPerguntaP;
    }
    break;
    case 2:
    Console.WriteLine($"Insira o valor que deseja converter para Dólar:");
    float resultadoD = float.Parse(Console.ReadLine()!);    
    resultadoFinal = Conversor.ConverterRealemdolar(resultadoD);
    Console.WriteLine($"{resultadoFinal.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
    VoltaPergunta:
    Console.WriteLine($"Deseja voltar para o menu? s para sim e n para não");
    string validacao = Console.ReadLine()!;
    switch (validacao)
    {
        case "s":
        goto Volta;
        case "n":
        break;
        default:
        Console.WriteLine($"Insira algo valido");
        goto VoltaPergunta;
    }
    
    break;
    case 0:
    Console.Write($"Saindo");
    Console.Write($".");
    Console.Beep(1000,500);
    Console.Write($".");
    Console.Beep(1000,500);
    Console.Write($".");
    Console.Beep(1000,500);
    Console.WriteLine();
    Console.WriteLine($"Bye");
    break;
    default:
    Console.WriteLine($"Por favor insira um número válido");
    goto Volta;
}
