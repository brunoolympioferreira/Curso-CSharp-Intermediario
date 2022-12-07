namespace _06_PropriedadeAbstrata.Lib;
class Carro : Veiculo
{
    public override string Marca { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override string Modelo => throw new NotImplementedException();
}
