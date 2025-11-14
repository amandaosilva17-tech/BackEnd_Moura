using ExercicioPolimorfismo;

PagamentoPIX compraPIX = new PagamentoPIX();
compraPIX.ValorCompra = 15000;

float valorPagar = compraPIX.CalcularTotal();
Console.WriteLine($"Produto: Smartphone");
Console.WriteLine($"Preço: {compraPIX.ValorCompra}");
Console.WriteLine($"Forma de Pagamento: Pix");
Console.WriteLine($"Pagamento com Desconto: {valorPagar}");

Console.WriteLine();

PagamentoCartao compraCartao = new PagamentoCartao();
compraCartao.ValorCompra = 50; 

Console.WriteLine($"Produto: Caneca");
Console.WriteLine($"Preço: {compraCartao.ValorCompra}");
Console.WriteLine($"Forma de pagamento Cartão");
Console.WriteLine($"Pagamento com Acréscimo: {compraCartao.CalcularTotal()}");