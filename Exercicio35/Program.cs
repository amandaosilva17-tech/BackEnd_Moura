
//Faça um programa que solicite ao usuário um número de repetições “x”. Para cada
//repetição solicite dois números e imprima qual é o maior deles.

Console.WriteLine($"Quantos numeros voce quer digitar?");
int x = int.Parse(Console.ReadLine);

int contador = 1;

while (contador <= x)
{
    Console.WriteLine($"Digite o primeiro  numero:");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Digite o segundo numero:");
    n2 = int.Parse(Controle.ReadLine());
    
    if (n1 > n2)
    {//primeiro é maior 
        Console.WriteLine($"O numero {n1} é maior que {n2}");

    }
        else if (n2 > n1)
        {//segundo é o maior}\
            Console.WriteLine($"O numero {n2} é o maior que {n1}");

        }
        else 
        {//os números são iguais
            Console.WriteLine($"{n1} e {n2} são iguais!");

        }
}