﻿Console.WriteLine($"Informe o número correspondente ao dia da semana - exemplo 2 = segunda");
int diaSemana = int.Parse(Console.ReadLine());

switch (diaSemana) 
{
    case 1:
        Console.WriteLine($"hoje é domingo !");
        break;
    case 2:
        Console.WriteLine($"hoje é segunda !");
        break;
    case 3:
        Console.WriteLine($"hoje é terça !");
        break;
    case 4:
        Console.WriteLine($"hoje é quarta !");
        break;
    case 5:
        Console.WriteLine($"hoje é quinta !");
        break;
    case 6:
        Console.WriteLine($"hoje é sexta !");
        break;
    case 7:
        Console.WriteLine($"hoje é sabado !");
        break;
    default:
        Console.WriteLine($"O dia informado não corresponde a nenhum dia da semana.");
        break;
    
}