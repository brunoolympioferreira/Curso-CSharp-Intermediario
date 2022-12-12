namespace _02_PalavraBase;
internal class Carro : Veiculo
{
    public override void Andar()
    {
        base.Andar();
        Console.WriteLine("Carro Andando");
    }
}
