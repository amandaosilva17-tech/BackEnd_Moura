
//CRIAR UM NOVO PROJETO CHAMADO DesafioParesImpares
//PERGUNTAR AO USUÁRIO QUANTOS NÚMEROS ELE QUER DIGITAR 
//EXIBIR ,SEPARADAMENTE, OS NÚMEROS PARES E OS NÚMEROS IMPARES QUE ELE DIGITAR


Console.WriteLine($"Quantos números voce quer digitar?");
int qtdNumeros = int.Parse(Console.ReadLine());
string pares = "Pares: ";
string impares ="Impares: ";

for (int i =  1; i <= qtdNumeros; i++)
{
    Console.WriteLine($"Digite o {i}ª número:");
    int numeroDigitado = int.Parse(Console.ReadLine());

    if (numeroDigitado % 2 == 0)
    {//é par?
       pares += numeroDigitado.ToString() + ", "; //guarda o número com texto/string 
    }
  else
{
  impares += numeroDigitado.ToString() + ", ";
}

}   

Console.Clear();
Console.WriteLine($"RESULTADO:");
Console.WriteLine();
Console.WriteLine(pares);
Console.WriteLine(impares); 
