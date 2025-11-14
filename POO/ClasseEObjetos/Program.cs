using ClasseEObjetos;

Console.Clear();
Console.WriteLine($"== Agencia Bancária ==");
Console.WriteLine();

AgenciaBancaria contaDoJoao = new AgenciaBancaria

contaDoJoao.Titular = "Diogo Farias";
contaDoJoao.Saldo = 1000.98f;

contaDoJoao.Depositar(500);

contaDoJoao.Sacar(1500);
