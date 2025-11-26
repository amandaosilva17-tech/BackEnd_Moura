
using System.Diagnostics.Contracts;
using System.Runtime.Intrinsics.X86;

namespace Encapsulamento02
{
    
    public class ContaBancaria
    {
        public float Saldo;
        
        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float saldoInicial)
        {
            if (saldoInicial > 0)
            {
                Saldo = saldoInicial;
            }
            else 
            {
                Saldo = 0;
            }
            
        }
        

        public void Depositar(float valor)
        {
            Saldo += valor;
        }

        public void Sacar(float valor)
        {
            Saldo -= valor;
        }

        public void Depositar(float valor)
        {
            if (valor <= 0)    
        }

        public float GetSaldo()
        {
            
            
        }

        public void Sacar(float valor)
        {
            if (alor >= 0 && valor <= Saldo) 
            {
                Saldo -= valor;
                Console.WriteLine($"Saque efetuado com sucesso!");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente ou negativo:");
            }
        }
    }
}