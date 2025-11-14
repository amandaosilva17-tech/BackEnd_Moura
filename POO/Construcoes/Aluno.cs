namespace Construcoes
{
    public class Aluno
    {
        public string Nome;

        public int Nota;

        public Aluno()
        {
            Console.WriteLine($"Lista de alunos:");
        }

        public Aluno(String n, int m)
        {
            Nome = n;
            Nota = m;
        }

        public void ExibirDados
        ()
        { }
    }
}