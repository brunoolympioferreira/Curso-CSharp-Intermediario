namespace _03_ConstrutorBase;
internal class Veiculo
{
    public Veiculo()
    {
        Console.WriteLine("Construindo Veículo");
    }
    public Veiculo(int i)
    {
        Console.WriteLine("Construindo Veículo N: " + i);
    }
    public virtual void Andar()
    {
        Console.WriteLine("Veiculo Andando");
    }
}
