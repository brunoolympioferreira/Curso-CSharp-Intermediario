namespace InterfacePolimorfismo;
internal class Carro : Veiculo, ITransporte
{
    public void Andar()
    {
        Console.WriteLine("Carro andando...");
    }
}
