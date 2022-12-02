double valor = 25;

Console.WriteLine("Main > var valor:" + valor);

AlterarValor(out valor);

int idade;
string nome = RetornarNomeIdadePessoa(new DateTime(10,10,2000), out idade);

Console.WriteLine("Main > var valor:" + valor);

Console.ReadKey();


static void AlterarValor(out double valor)
{
    valor = 10;
}

static string RetornarNomeIdadePessoa(DateTime dataNascimento, out int idade)
{
    idade = 10;
    return "Nome";
}
