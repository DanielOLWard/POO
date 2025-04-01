//// Exercicios 25/03

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

//// Exercicios 26/03

//// Exercicio 01 - Classe ContaBancaria
////Crie uma classe chamada `ContaBancaria` que tenha:
////-Um atributo privado `_saldo` (com valor padrão de 0).
////- Um método público `Depositar(double valor)`, que adiciona um valor ao saldo.
////- Um método público `Sacar(double valor)`, que subtrai um valor do saldo (se houver saldo suficiente).
////- Um método público `VerSaldo()`, que retorna o saldo atual.
////Crie um objeto dessa classe e faça algumas operações de depósito e saque.

//using POO;

//ContaBancaria contaBancaria = new ContaBancaria();
//contaBancaria.Depositar();
//contaBancaria.VerSaldo();
//contaBancaria.Sacar();
//contaBancaria.VerSaldo();

//// exercicio 02 - Classe Funcionario
////Crie uma classe `Funcionario` com:
////-Um atributo privado `_salario`.
////- Métodos `SetSalario(valor)` e `GetSalario()`
////    - **SetSalario** → Modifica o salario com o valor fornecido pelo usuario
////    - **GetSalario** → Retorna o Salario
////Crie um objeto, defina um salário e exiba o valor usando `GetSalario()`.
//using POO;

//Funcionario funcionario = new Funcionario();
//funcionario.SetSalario();
//funcionario.GetSalario();

//// Exercicio 03 - Classe Retangulo
////Crie uma classe `Retangulo` com:
////-Dois atributos privados `_largura` e `_altura`.
////- Métodos `SetLargura(valor)`, `SetAltura(valor)`, `GetLargura()` e `GetAltura()`.
////    - **SetLargura** → Modifica a _largura com o valor fornecido pelo usuario
////    - **SetAltura** → Modifica a _altura com o valor fornecido pelo usuario
////    - **GetLargura** → Retorna a Largura
////   - **GetAltura** → Retorna a Altura
////- Um método público `CalcularArea()`, que retorna a área do retângulo.
////Crie um objeto, defina largura e altura, e exiba a área calculada.

//using POO;

//Retangulo retangulo = new Retangulo();
//Console.Write("Escreva a Largura: ");
//retangulo.SetLargura(double.Parse(Console.ReadLine()));
//Console.Write("Escreva a Largura: ");
//retangulo.SetAltura(double.Parse(Console.ReadLine()));
//Console.Write($"A area desse retangulo e: {retangulo.CalcularArea()}");

//// Exercicio 04 - Conta Corrente e Conta Poupança
////Utilizando a classe `ContaBancaria` criada no exercício 1, crie duas subclasses:
////- `ContaCorrente`: possui um método `CobrarTaxa()` que reduz o saldo em um valor fixo (ex: 10).
////- `ContaPoupanca`: possui um método `RenderJuros()`, que aumenta o saldo em 5%.
////Crie instâncias de ambas as classes, faça depósitos e utilize seus métodos específicos.

//using POO.Contas;

//ContaBancaria conta = new ContaBancaria();
//Console.WriteLine("Se sua conta for Corrente, Digite C, caso ela seja Poupanca, Digite P.");
//string escolha = Console.ReadLine();
//if (escolha == "C")
//{ 
//    conta = new ContaCorrente();
//   if (conta is ContaCorrente cc)
//    {
//        cc.Depositar();
//        Console.WriteLine("Por sua conta ser Corrente teve um rendimento de 5%");
//        cc.CobraTaxa();
//        cc.VerSaldo();
//        Console.WriteLine("deseja realizar um saque? S/N");
//        escolha = Console.ReadLine();
//        if (escolha == "S")
//        {
//            cc.Sacar();
//            cc.VerSaldo();
//        }
//        else if (escolha == "N")
//        {
//            Console.WriteLine("Tenha uma boa noite");
//        }
//    }
//}
//else if (escolha == "P")
//{
//    conta = new ContaPoupanca();
//    if (conta is ContaPoupanca cp)
//    {
//        cp.Depositar();
//        Console.WriteLine("Por sua conta ser Poupanca foi cobrada uma taxa de R$10,00");
//        cp.RenderJuros();
//        cp.VerSaldo();
//        Console.WriteLine("deseja realizar um saque? S/N");
//        escolha = Console.ReadLine();
//        if (escolha == "S")
//        {
//            cp.Sacar();
//            cp.VerSaldo();
//        }
//        else if (escolha == "N")
//        {
//            Console.WriteLine("Tenha uma boa noite");
//        }
//    }
//}