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

//// ferramentas - formas de trabalhar com POO

//// Emcapsulamento e Heranca

//// Emcapsulamento - Esconder comportamentos e atributos
//// Evitar que os dados sejam acessados diretamente

//// public - Esse atributo/metodo/classes podem ser acessadas por qualquer um.

//// private - Esse atributo/metodo/classes so pode ser acessado dentro dele mesmo.

//// protected/internal - Esse atributo/metodo/classes so pode ser acessado por ele mesmo e por sua classe pai

//// Abstracao e polimorfismo

// Polimorfismo depende de heranca
// Polimorfismo - Um metoddo "com o mesmo nome" pode ter implementacao variavel
// colocar o virtual na frente

// Abstracao - 

//// Exemplo de POO
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

//List<Carro> carros = new List<Carro>();
//carros.Add(carro1); 
//carros.Add(carro2);