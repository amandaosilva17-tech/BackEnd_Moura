namespace  Exercicio02
{
    public class Gerente : Funcionario
    {
        public float Bonus;

        public float CalcularSalario()
        {//retorna o salario base + bonus 
            return SalarioBase += Bonus; 
            
        }
    }
        
}