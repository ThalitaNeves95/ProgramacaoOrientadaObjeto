// Abstração - Muito ligado com Herança

// Interface - Contrato
// TrocarMarcha()

// Livro - (texto, autor, ano)
// MostrarDadosLivro()
// MostrarLivro()

// Toda interface comeca com I no icinio ICarro

using Abstracao;

ICarro carro = new CarroAutomatico();

carro.TrocarMarcha();

ICarro carro1 = new CarroManual();

carro1.TrocarMarcha();