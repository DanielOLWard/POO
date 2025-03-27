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
///
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

//// Abstracao e polimorfismo

//// protected/internal - Esse atributo/metodo/classes so pode ser acessado por ele mesmo e por sua classe pai
///
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
///
//// Exercicios 25/03 e 26/03

//// Exercicio 01 - Crie uma classe chamada `Livro` com os seguintes atributos:
////- `titulo` (tipo `string`)
////- `autor` (tipo `string`)
////- `paginas` (tipo `int`)

//Livro livro1 = new Livro();
//livro1.titulo = "Eu robo";
//livro1.autor = "Isaac Asimov";
//livro1.pagina = 315;

//Console.WriteLine(livro1.titulo);
//Console.WriteLine(livro1.autor);
//Console.WriteLine(livro1.pagina);

//// Exercicio 02 -Crie uma classe chamada `Aluno` com os seguintes atributos:
////- `nome` (tipo `string`)
////- `idade` (tipo `int`)
////- `notaFinal` (tipo `double`)
////Depois, crie dois objetos da classe `Aluno`, atribua valores a eles e exiba os detalhes de ambos.

//Aluno aluno1 = new Aluno();
//aluno1.nome = "Daniel";
//aluno1.idade = 20;
//aluno1.notaFinal = 6.9;

//Aluno aluno2 = new Aluno();
//aluno2.nome = "alexandryni";
//aluno2.idade = 19;
//aluno2.notaFinal = 6.6;

//Console.WriteLine(aluno1.nome);
//Console.WriteLine(aluno1.idade);
//Console.WriteLine(aluno1.notaFinal);
//Console.WriteLine(aluno2.nome);
//Console.WriteLine(aluno2.idade);
//Console.WriteLine(aluno2.notaFinal);

//// Exercicio 03 - Crie uma classe chamada `Produto` com os seguintes atributos:
////- `nome` (tipo `string`)
////- `preco` (tipo `double`)
////- `quantidadeEmEstoque` (tipo `int`)
////Também crie o seguinte método:
////- `CalcularTotal` que retorna o total da `quantidadeEmEstoque` *  `preco`
////Depois, crie um objeto da classe `Produto`, altere os valores dos atributos e imprima as informações antes e depois da alteração, também imprima o resultado do método CalcularTotal.

//using POO;

//Produto produto1 = new Produto();
//Console.Write("Digite o nome do produto: ");
//produto1.nome = Console.ReadLine();
//Console.WriteLine();
//Console.Write($"Digite o valor do {produto1.nome}: ");
//produto1.preco = double.Parse(Console.ReadLine());
//Console.WriteLine();
//Console.Write($"Digite quantos {produto1.nome} tem no estoque: ");
//produto1.qtdEestoque = int.Parse(Console.ReadLine());
//Console.WriteLine();
//Console.Write($"O valor total do {produto1.nome} e: ");
//Console.WriteLine(produto1.CalcularTotal());