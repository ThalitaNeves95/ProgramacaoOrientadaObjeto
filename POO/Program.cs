//// Vetor
//// string[] names = new string[5];

//// Listas
//// Generico

//// List<string> listaDeNomes = new List<string>();
//// OU

////List<string> listaDeNomes2 = ["Lia Mendes", "Thalita Neves", "Bjork"];
////using POO;

////List<string> listaDeNomes2 = new();

////listaDeNomes2.Add("Lia Mendes");
////listaDeNomes2.Add("Thalita Neves");
////listaDeNomes2.Add("Bjork");

////foreach (var item in listaDeNomes2)
////{
////    Console.WriteLine(item);
////}

////listaDeNomes2.Remove("Vinicio");

//// POO - Programação Orientada a Objetos

//// Programação Estruturada

//// Objetivo - Aproximar a Programação do Mundo Real 
//// Separar nossos Sistemas em Partes Menores

//// Classes e Objetos

//// Classe = Definição (Item da vida real representada em código)
//// Atributos (caracteristicas) - Metodos (ações)

//// Objeto - Instancia de uma Classe - Especifica
//// Todo objeto tem esse formato

//Carro carro1 = new Carro();
//// Para acessar informações do objeto, eu uso o "."
//carro1.modelo = "HB20";
//carro1.marca = "Hyundai";
//carro1.anoFabricacao = 2024;
//carro1.cor = "Azul";

//carro1.Andar();

//carro1.Parar();

////// Crie mais 2 carros

//Carro carro2 = new Carro();

//carro2.modelo = "BYD Song Pro";
//carro2.marca = "Build Your Dreams";
//carro2.anoFabricacao = 2025;
//carro2.cor = "Preto";

//carro2.Andar();

//carro2.Parar();

//Carro carro3 = new Carro();

//carro3.modelo = "Corolla Cross XRV";
//carro3.marca = "Toyota";
//carro3.anoFabricacao = 2025;
//carro3.cor = "Prata";

//carro3.Andar();

//carro3.Parar();

//// Guardar carros numa lista
//List<Carro> carros = new List<Carro>();
//carros.Add(carro1);
//carros.Add(carro2);
//carros.Add(carro3);

//// 1 - Criando uma Classe "Livro" e Instanciando um Objeto
//// Crie uma classe chamada `Livro` com os seguintes atributos:

////// Jeito abreviado 
//Livro livro = new Livro()
//{
//    titulo = "Assim Falou Zaratustra",
//    autor = "Friedrich Nietzsche",
//    paginas = 288
//};

////// Jeito não abreviado

//Livro livro1 = new Livro();

//livro1.titulo = "Assim Falou Zaratustra";
//livro1.autor = "Friedrich Nietzsche";
//livro1.paginas = 288;

//Livro livros2 = new Livro();

//livros2.titulo = "Macunaíma";
//livros2.autor = "Mario de Andrade";
//livros2.paginas = 188;

//Console.WriteLine(livro1.titulo);
//Console.WriteLine(livro1.autor);

//// 4 Pilates da POO

//// Classe e Objeto
//// Classe é a definição (molde usado) Ex.: Forma de bolo redonda
//// Objeto - Instancia da classe - O bolo redondo :)

//// 2.Criando e Utilizando um Objeto "Aluno"
//// Crie uma classe chamada `Aluno` com os seguintes atributos:

//Aluno aluno = new Aluno();

//aluno.nome = "Thalita Neves";
//aluno.idade = 29;
//aluno.notaFinal = 7.8;

//Aluno aluno2 = new Aluno()
//{
//    nome = "Lia Mendes",
//    idade = 39,
//    notaFinal = 8.9
//};

//// 3.Criando uma Classe "Produto" e Trabalhando com Objetos
//// Crie uma classe chamada `Produto` com os seguintes atributos:

//Produto produto = new Produto();

//produto.nome = "Macarrão Barilla";
//produto.preco = 4.99;
//produto.quantidadeEmEstoque = 120;

//Console.WriteLine(produto.CalcularTotal());

//// Ferramentas - Formas de Trabalhar com POO

//// Encapsulamento e Herança

//// Abstração e Polimorfismo

//// Encapsulamento - Esconder comportamentos e atributos
//// Evitar que sejam acessados diretamente
//// Conta Bancária (Saldo)
//// Sacar() - Depositar() podem acessar o saldo
//// Ex.: conta.saldo = 3000;
//// Vantagens:
//// 1 - Esconder atributos/metodos/classe
//// 2 - Defino regras para alteração ou listagem

//// Existem 4 palavras possíveis:
////// public - Esse atributo/metodo/classe pode ser acessado por qualquer um - Atributos, metodos e classes
/////
////// private - Esse atributo/metodo só pode ser acessado dentro dele mesmo, onde foi criado
/////
////// protected/internal -  atributo/metodo/classe só pode ser acessado por ele mesmo e por sua classe pai

//// Get - metodo para pegar um atributo privado
//// Set - é o metodo para alterar um atributo privado

//carro1.SetModelo("Fiesta");

//Console.WriteLine(carro1.GetModelo());

// 4 Pilares

// Banco de Dados - SQL Server

// Desenvolvimento Backend

// Polimorfismo depende de herança
// Polimorfismo - Um metodo (com mesmo nome) pode ter implementação váriavel
// Um metodo pode fazer coisas diferentes - Ex.: TrocarMarcha - CarroAutomatico/CarroManual