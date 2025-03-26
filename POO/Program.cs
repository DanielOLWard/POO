//// Listas
////List<string> listasDeNomes = new List<string>();  //modo normal

//List<string> listasDeNomes = new();  //Modo abreviado

//listasDeNomes.Add("Daniel");
//listasDeNomes.Add("Ward");
//listasDeNomes.Add("leinaD");

//foreach (var item in listasDeNomes)
//{
//    Console.WriteLine(item);
//}

//listasDeNomes.Remove("leinaD");

//// POO - Programacao Orientada a Objetos

//// Objetivo - Aproximar a programcao do mundo real
//// Separar nossos sistemas em Partes Menores

//// Classes e Objetos

//// Classe - Definicao (item da vida real representada em codigo)
//// Atributos (caracteriscas) - metodos (acoes)

//// Objeto - Instancia de uma classe
//using POO;

//Carro carro1 = new Carro();

//// Para acessar informacoes do objeto eu uso o "."
//carro1.modelo = "HB20";
//carro1.marca = "hyundai";
//carro1.anoFabricacao = 2024;
//carro1.Andar();
//carro1.Parar();


//Carro carro2 = new Carro();
//carro2.modelo = "Strada";
//carro2.marca = "Fiat";
//carro2.anoFabricacao = 2021;
//carro2.Andar();
//carro2.Parar();


//Carro carro3 = new Carro();
//carro3.modelo = "Classic";
//carro3.marca = "GM";
//carro3.anoFabricacao = 2013;
//carro3.Andar();
//carro3.Parar();

//List<Carro> carros = new List<Carro>();
//carros.Add(carro1); 
//carros.Add(carro2);
//carros.Add(carro3);

using POO;

Livro livro1  = new Livro();
livro1.titulo = "Eu robo";
livro1.autor = "Isaac Asimov";
livro1.pagina = 315;

List<Livro> livros = new List<Livro>();
livros.Add(livro1);
foreach (var item in livros)
{
    Console.WriteLine(item.titulo);
    Console.WriteLine(item.autor);
    Console.WriteLine(item.pagina);

}