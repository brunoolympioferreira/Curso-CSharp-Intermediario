using InterfacePolimorfismo;

Carro carro = new Carro();
SobreVeiculo(carro);
SobreTransporte(carro);

Console.ReadKey();

static void SobreVeiculo(Veiculo veiculo)
{
    Console.WriteLine(veiculo.Marca);
}

static void SobreTransporte(ITransporte transporte)
{
    transporte.Andar();
}