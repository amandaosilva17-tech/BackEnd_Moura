namespace Construtores
{
    public class Carro
    {
        public string Marca;

        public string Modelo;

        public int Ano;

        public Carro(string marca, string modelo, int ano)
        {
            //preenchendo os dados iniciais na classe
            Marca = marca;
            Modelo = modelo;
            Ano = ano;

            ExibirDados();//exibe as informações na classe

        }

            public void ExibirInfo()
        {
            Console.WriteLine($"Marca:  {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Quantas portas: {QPortas}");

        }



    }
}