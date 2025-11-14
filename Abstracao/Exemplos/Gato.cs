
namespace Exemplos
{
    public class Gato : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"Miauzinho");
        }

        public override void Mover()
        {

            Console.WriteLine($"ploc ploc ploc");
        }


    }
}

