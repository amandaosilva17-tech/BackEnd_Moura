
using System.Security.Cryptography.X509Certificates;

namespace ExercicioPolimorfismo
{
    
    public class PagamentoPIX : Pagamento
    {
        private float desconto = 5; 
        public float ValorCompra; 

        public override float CalcularTotal()
        {
            float valordesconto = ValorCompra / 100 * desconto; 
            return ValorCompra  = ValorCompra - valordesconto;
        }

    }
}