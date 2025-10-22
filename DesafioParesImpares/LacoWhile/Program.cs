
int contador = 1;

Console.WriteLine($"Quantas vezes voce que rodas o while?");

int qrtVezes = int.Parse(Console.ReadLine());

while (contador <= qrtVezes)
{
    Console.WriteLine($"Contador é: {contador}");
    contador++; 
}


