namespace _03_Encapsulamento;

class Pessoa
{
    private string Nome;
    string CEP;
    string Endereco;
    string CPF;

    public void SetNome(string nome)
    {
        Nome = nome.Trim().ToUpper();
    }

    public string GetNome()
    {
        return Nome.ToLower();
    }
}
