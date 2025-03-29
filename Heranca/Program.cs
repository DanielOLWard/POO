////// Heranca - Classe que herda de outra

//using Heranca;

//CarroEletrico carroE = new CarroEletrico();
//carroE.marca = "BYD";
//carroE.bateria = 500;

//CarroCombustao carroC  = new CarroCombustao();
//carroC.marca = "Fiat";
//carroC.combustivel = "gasolina";

//Carro meucarro;
//Console.WriteLine("Digite E - para carro eletrico ou Digite C - para Combustao");
//string opcao  = Console.ReadLine();

//if (opcao == "E")
//{
//    meucarro = new CarroEletrico();
//}
//else
//{
//    meucarro = new CarroCombustao();
//}

//using Heranca.Pessoa;

//Pessoa pessoa;
//Console.WriteLine("Escreva CNPJ para pessoa juridica ou CPF para pessoa fisica");
//string escolha  = Console.ReadLine();
//if (escolha == "CNPJ")
//{
//    pessoa = new Juridica();
//    Console.WriteLine("Voce e pessoa JURIDICA!!");
//}
//else if (escolha == "CPF")
//{
//    pessoa = new Fisica();
//    Console.WriteLine("Voce e pessoa FISICA!!");
//}
//else
//{
//    Console.WriteLine("Escolha uma opcao valida");
//}

using Heranca.Carros;

Carro carro1 = new Carro();

CarroEletrico CarroE = new CarroEletrico();

carro1.modelo = "Strada";
carro1.marca = "Fiat";
carro1.quilometragem = 62000;
carro1.MostrarInformacoes();

CarroE.modelo = "Tesla Model S";
CarroE.marca = "Tesla";
CarroE.quilometragem = 0;
CarroE.bateria = 500000;
CarroE.tempoDeCarga = 120;
CarroE.MostrarInformacoes();

carro1.MostrarInformacoes("Daniel");