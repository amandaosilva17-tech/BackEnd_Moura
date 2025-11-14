
using System.Runtime.Intrinsics.Arm;
using Calculadora;

Console.Clear();

Calculator calc = new Calculator();

Console.WriteLine($"===Calculadora C# Console===");
Console.WriteLine();

int opcao = -1;


do
{
    Console.WriteLine($"Menu");
    Console.WriteLine($"   1)Somar");
    Console.WriteLine($"   2)Subtrair");
    Console.WriteLine($"   3)Multiplicar");
    Console.WriteLine($"   4)Dividir");
    Console.WriteLine($"   0)Sair");
    Console.WriteLine($"Escolha uma opção:");
    opcao = int.Parse(Console.ReadLine());

    Console.WriteLine($"Digite o primeiro número");
    calc.Numero1 = double.Parse(Console.ReadLine());
    Console.WriteLine($"Digite o segundo número");
    calc.Numero2 = int.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Resultado da soma: {calc.Somar()}");
            break;

        case 2:
            Console.WriteLine($"Resultado da soma: {calc.Subtrair()}");
            break;

        case 3:
            Console.WriteLine($"Resultado da soma: {calc.Multiplicar()}");
            break;

        case 4:
            Console.WriteLine($"Resultado da soma: {calc.Dividir()}");
            break;

        case 0:
            Console.WriteLine($"Obrigada por utilizar o meu programa! :) Saindo...");
            break;

        default:
            Console.WriteLine($"Opção invalida ผ(•̀_•́ผ)! Escolha uma opção que se encaixe no padrão!");
            break;
    }

    Console.WriteLine($"Digite <ENTER> para sair!");
    Console.ReadLine();
    
} while (opcao != 0);




calc.Numero1 = 50;
calc.Numero2 = 10;

Console.WriteLine($"===Calculator===");
Console.WriteLine($"Resultados: ");
Console.WriteLine($"Primeiro número: {calc.Numero1}");
Console.WriteLine($"Segundo número: {calc.Numero2}");


Console.WriteLine($"Soma: {calc.Somar()}");
Console.WriteLine();

Console.WriteLine($"Subtração: {calc.Subtrair()}");
Console.WriteLine();

Console.WriteLine($"Multiplicação: {calc.Multiplicar()}");
Console.WriteLine();

Console.WriteLine($"Divisão: {calc.Dividir()}");
Console.WriteLine();
