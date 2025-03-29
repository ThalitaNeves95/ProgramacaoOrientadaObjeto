// Heranca - Classe que herda de outra

// Carro - Modelo, Marca, Quilometragem
// CarroEletrico - Bateria, TempoDeCarga
// CarroCombustao - Combustivel

using Heranca;

CarroEletrico carroEletrico = new CarroEletrico();

carroEletrico.marca = "BYD";
carroEletrico.modelo = "Dolphin";
carroEletrico.bateria = 12;
carroEletrico.tempoDeCarga = 5;
carroEletrico.quilometragem = 9500;

CarroCombustao carroCombustao = new CarroCombustao();

carroCombustao.marca = "Toyota";
carroCombustao.modelo = "Corolla";
carroCombustao.combustivel = "Flex";
carroCombustao.quilometragem = 11530;

carroEletrico.MostrarInformacoes();

carroCombustao.MostrarInformacoes("Thalita");