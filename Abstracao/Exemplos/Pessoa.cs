


using Exemplos;

namespace Exemplos
{
    public class Pessoa : Animal 
    {
        public string Nome; 

        public string Idade;

        public override void FazerSom()
        {
            Console.WriteLine($"oi vey)");
        }

        public override void Mover()
        {
            Console.WriteLine($"desculpa mãe");
        }


        public  abstract void 
    }
}

Pessoa edu = new Pessoa();
edu.Nome = "Eduador Mendes"; 
edu.Idade = 43; 

Console.WriteLine($"Nome: {edu.Nome}");
Console.WriteLine($"Idade do {edu.Nome}: {edu.Idade} anos");

Console.WriteLine($"Som do {edu.Nome}: ");
edu.FazerSom();
Console.WriteLine($"{edu.Nome} está se movendo: ");
edu.Mover();

Console.WriteLine($"{edu.Nome} foi dormir");
edu.Dormir();
Console.Clear();
