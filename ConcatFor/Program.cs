//Perguntar ao usuário quantas letras tem o nome dele
// depois vamos pedir letra a letra de seu nome 
// ao final, vamos exibir o nome do usuário completo 

int qtdLetras = 0;

Console.WriteLine($"Olá usuário, quantas letras tem o seu nome?");
qtdLetras = int.Parse(Console.ReadLine()); //guarda o número na variável 
string nome = "";

for (int i = 1; i <= qtdLetras; i++)
{
    Console.WriteLine($"Qual é a {i}ª letra?");
    nome += Console.ReadLine();
} 


Console.WriteLine($"Seu nome é:{nome}");

//CRIAR UM NOVO PROJETO CHAMADO DesafioParesImpares
//PERGUNTAR AO USUÁRIO QUANTOS NÚMEROS ELE QUER DIGITAR 
//EXIBIR ,SEPARADAMENTE, OS NÚMEROS PARES E OS NÚMEROS IMPARES QUE ELE DIGITAR
