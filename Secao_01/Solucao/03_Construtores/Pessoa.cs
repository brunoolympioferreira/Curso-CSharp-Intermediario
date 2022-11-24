namespace _03_Construtores
{
    class Pessoa
    {
        string Nome;
        string Sexo;
        DateTime DataNascimento;
        double PosicaoX, PosicaoY;

        public Pessoa(string nome, string sexo, DateTime dataNascimento, double x, double y)
        {
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            PosicaoX = x;
            PosicaoY = y;
        }
    }
}
