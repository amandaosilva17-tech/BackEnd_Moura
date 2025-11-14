ContaCorrente cc = new ContaCorrente();
ContaPoupanca cp = new ContaPoupanca();

cc.Depositar(500);
cp.Depositar(500);

Console.WriteLine("=== CONTA CORRENTE ===");
Console.WriteLine($"Saldo inicial: {cc.Saldo}");
cc.Sacar(100);
Console.WriteLine($"Saldo após saque: {cc.Saldo}");

Console.WriteLine("\n=== CONTA POUPANÇA ===");
Console.WriteLine($"Saldo inicial: {cp.Saldo}");
cp.Sacar(100);
Console.WriteLine($"Saldo após saque: {cp.Saldo}");


