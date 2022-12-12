namespace _01_PalavraThis;
internal class Carro
{
    string Marca;
    string Modelo;
    string AnoFabricacao;
    string AnoModelo;

    public void SetMarca(string Marca)
    {
        this.Marca = Marca;
        this.SetModelo(Modelo);
    }

    public void SetModelo(string Modelo)
    {
    }
}
