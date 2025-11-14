namespace ExercicioPolimorfismo
{
    public class PagamentoCartao : Pagamento
    {
        private float acrescimo = 5.38f;

        public float ValorCompra;

        public override float CalcularTotal()
        {
            float valoracrescimo = ValorCompra/100 * acrescimo; 
            return ValorCompra = ValorCompra + valoracrescimo;
        }


    }
}