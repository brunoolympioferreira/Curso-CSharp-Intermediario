using _02_TratandoException;

string gerarCodigo;
try
{
    Pessoa pessoa = new();
    pessoa.SetCEP("abc10");
}
catch (FormatException ex)
{
    Console.WriteLine("ERRO FORMAT: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}
finally
{
    gerarCodigo = null;
}

Console.ReadKey();