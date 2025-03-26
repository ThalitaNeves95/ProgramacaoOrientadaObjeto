// Vetor
// string[] names = new string[5];

// Listas
// Generico

// List<string> listaDeNomes = new List<string>();
// OU

// List<string> listaDeNomes2 = ["Lia Mendes", "Thalita Neves", "Bjork"];
//List<string> listaDeNomes2 = new();

//listaDeNomes2.Add("Lia Mendes");
//listaDeNomes2.Add("Thalita Neves");
//listaDeNomes2.Add("Bjork");

//foreach (var item in listaDeNomes2)
//{
//    Console.WriteLine(item);
//}

// listaDeNomes2.Remove("Vinicio");

// POO - Programação Orientada a Objetos

// Programação Estruturada

// Objetivo - Aproximar a Programação do Mundo Real 
// Separar nossos Sistemas em Partes Menores

// Classes e Objetos

// Classe = Definição (Item da vida real representada em código)
// Atributos (caracteristicas) - Metodos (ações)

// Objeto - Instancia de uma Classe - Especifica
// Todo objeto tem esse formato
//using POO;

//Carro carro1 = new Carro();
//// Para acessar informações do objeto, eu uso o "."
//carro1.modelo = "HB20";
//carro1.marca = "Hyundai";
//carro1.anoFabricacao = 2024;
//carro1.cor = "Azul";

//carro1.Andar();

//carro1.Parar();

//// Crie mais 2 carros

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

// 1 - Criando uma Classe "Livro" e Instanciando um Objeto
// Crie uma classe chamada `Livro` com os seguintes atributos:

using POO;

Livros livros = new Livros();

livros.titulo = "Assim Falou Zaratustra";
livros.autor = "Friedrich Nietzsche";
livros.paginas = 288;

Livros livros2 = new Livros();

livros2.titulo = "Macunaíma";
livros2.autor = "Mario de Andrade";
livros2.paginas = 188;

Console.WriteLine(livros.titulo);
Console.WriteLine(livros.autor);


