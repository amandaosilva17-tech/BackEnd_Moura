namespace Exemplos
{
    public class Cachorro : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"Thor");
        }

        public override void Mover()
        {
            Console.WriteLine($"au au au");
        }


    }
}