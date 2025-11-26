using Encapsulamento2;

ContaBancaria contaMaria = new ContaBancaria();
ContaBancaria contaIsa = new ContaBancaria(1500);

contaMaria.Depositar(-100);
contaMaria.Depositar(20);

contaMaria.Sacar(-200);
contaIsa.Sacar(300);

Console.WriteLine();

Console.WriteLine($"Saldo atual de Maria : R${contaVick.GetSaldo()}");
Console.WriteLine($"Saldo atual de Isa R${contaNikki.GetSaldo()}");
