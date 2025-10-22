int qntdUsuario = 0;
int contador = 1;
Console.WriteLine("Quanto Números voce quer digitar?");
qntdUsuario = int.Parse(Console.ReadLine());

while (contador <= qntdUsuario)
{
    Console.WriteLine($"Digite um Numero:");
    int batata = int.Parse(Console.ReadLine());
    if (batata % 2 == 0)
    {
        Console.WriteLine($"Numero digitado eh Par: {batata}");
    }
    Contador++;
} 