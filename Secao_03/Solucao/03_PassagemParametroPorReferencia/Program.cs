double valor = 25;

Console.WriteLine("Main > var valor:" + valor);

AlterarValor(ref valor);

Console.WriteLine("Main > var valor:" + valor);

Console.ReadKey();


static void AlterarValor(ref double valor)
{
    Console.WriteLine("Alterar valor > var valor:" + valor);

    valor += 10;

    Console.WriteLine("Alterar valor > var valor:" + valor);
}
