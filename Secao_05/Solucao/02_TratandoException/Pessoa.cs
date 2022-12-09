namespace _02_TratandoException;
public class Pessoa
{
    private string nome;
    private string CPF;
    private string CEP;

    public void SetCEP(string cep)
    {
        int resultado;
        int.Parse(cep);
        if (int.TryParse(CEP, out resultado))
        {
            // valido
            CEP = cep;
        }
        else
        {
            throw new Exception("CEP inválido!");
        }
    }
}
