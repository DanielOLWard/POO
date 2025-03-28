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

using Heranca;

Pessoa pessoa;
Console.WriteLine("Escreva CNPJ para pessoa juridica ou CPF para pessoa fisica");
string escolha  = Console.ReadLine();
if (escolha == "CNPJ")
{
    pessoa = new Juridica();
    Console.WriteLine("Voce e pessoa JURIDICA!!");
}
else if (escolha == "CPF")
{
    pessoa = new Fisica();
    Console.WriteLine("Voce e pessoa FISICA!!");
}
else
{
    Console.WriteLine("Escolha uma opcao valida");
}