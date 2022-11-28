namespace _02_ModificadoresAcessoParte1.Lib;

public class Caminhao : Veiculo
{
    byte QtRoda = 10;

    void InfoCaminhao()
    {
        Modelo = "1520";
        AnoModelo = new DateTime(2010,10,20);
    }
}
