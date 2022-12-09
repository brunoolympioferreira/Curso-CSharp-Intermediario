namespace _03_CustomizarException;
public class MinhaException : Exception
{
    string linhadoErro;
    public MinhaException(string linha) : base("Minha Exception")
    {
        linhadoErro = linha;
    }
}
