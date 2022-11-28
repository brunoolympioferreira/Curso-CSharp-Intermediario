using _02_ModificadoresAcessoParte1.Lib;

Veiculo veiculo = new Veiculo();
Carro carro = new Carro();
Caminhao caminhao = new Caminhao();

caminhao.Marca = "VOLVO";
carro.Marca = "FIAT";
Console.Write(veiculo.Marca);

carro.AnoModelo = new DateTime(0, 0, 2000);


