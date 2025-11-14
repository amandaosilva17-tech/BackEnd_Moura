namespace Exemplos
{
    public abstract class ContaCorrente : ContaBancaria
    {public abstract class ContaBancaria
    {
        public double Saldo;

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public abstract void Sacar(double valor);
        {
            if(valor <= 0)
            {
                Console.WriteLine($"O valor do depósito deve ser positivo");
                return;
            }
            Saldo += valor;
        }
        public override void Sacar(double valor)
        {

            double TotalComTaxa = (valor / 100 * TaxaSaque) + valor;
            if(valor <= 0 || Saldo < TotalComTaxa)
            {
                System.Console.WriteLine($"O valor do saque deve ser positivo e ter dinheiro na conta");
                return;
            }

            Saldo -= TotalComTaxa;
            throw new NotImplementedException();
        }
    }
}