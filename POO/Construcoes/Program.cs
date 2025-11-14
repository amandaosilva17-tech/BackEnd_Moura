using Construcoes;
using Construtores;
Console.Clear();
Pessoa michele = new Pessoa();
Pessoa joao = new Pessoa("João Costa", 17);

michele.Nome = "Michele alves"();
michele.Idade = 20;

joao.ExibirDados();
michele.ExibirDados();



Carro s25 = new Carro($"Ferrari", "", 2025);

Aluno Milena = new Aluno();
Milena.Nome = "Milena";
Milena.Nota = 10;
Milena.ExibirDados();

Aluno gustavo = new Aluno("", 0);


//para criar um produto qualquer 
Produto celular = new Produto("Samsung", 1500, 30);

celular.ExibirDados();


