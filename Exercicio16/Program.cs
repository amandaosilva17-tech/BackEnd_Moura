//Uma empresa decide dar aumento aos funcionários de acordo com o seu cargo,
// disposto na tabela abauixo 

// Produção - 6.5 
// Admnistrativo - 7.5
// Diretoria - 12 

// salario - salario * 1.65

//De acordo com a tabela acima faça um programa que receba o cargo e o salário de um funcionário e calcule e imprima o salário reajustado.

string cargo; 
double salario, salarioNovo = 0;

float saldo = 200.95f;
double saldo2 = 200.95f;

Console.WriteLine($"Digite o cargo do funcionario producao, administrativo ou diretoria");
cargo = Console.ReadLine();

Console.WriteLine($"digite o salario do funcionario");
salario = double.Parse(Console.ReadLine());

if (cargo == "producao")
{
    salarioNovo = salario + (salario * 0.075f);

}

else if (cargo == "administrativo")
{
    salarioNovo = salario + (salario * 0.075);

}

else if (cargo == "diretoria")
{
    salarioNovo = salario + (salario * 0.12);
}

else 
{
    Console.WriteLine($"Cargo invalido");
    return; 
}

Console.WriteLine($"o novo salario reajustado e {salarioNovo}");