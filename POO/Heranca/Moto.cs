namespace Heranca
{
    public class Moto : Veiculo
    {
        public string pedal; 

        public void ExibirInfo()

        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Quantas portas:: {pedal}");

        } 
 
          public void Acelerar()
        {
            Console.WriteLine($"Acelerando o veículo");
            
        }

    }
}