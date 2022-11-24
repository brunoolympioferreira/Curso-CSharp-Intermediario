namespace _02_Metodos;

class Pessoa
{
    public string Nome;
    public string Sexo;
    public DateTime DataNascimento;
    public double PosicaoX, PosicaoY;

    public string PegarPosicao()
    {
        return PosicaoX + " , " + PosicaoY;
    }

    public void SetPosicao(double X, double Y)
    {
        PosicaoX = X;
        PosicaoY = Y;
    }
}
