namespace _03_ConstrutorBase;
internal class Carro : Veiculo
{
    public Carro(int i) : base(i)
    {
        Console.WriteLine("Construindo Carro");
    }
    public override void Andar()
    {
        base.Andar();
        Console.WriteLine("Carro Andando");
    }
}
