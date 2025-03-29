// 1. Classe ContaBancaria
// Crie uma classe chamada `ContaBancaria` que tenha:
// -Um atributo privado `_saldo` (com valor padrão de 0).
// - Um método público `Depositar(double valor)`, que adiciona um valor ao saldo.
// - Um método público `Sacar(double valor)`, que subtrai um valor do saldo (se houver saldo suficiente).
// - Um método público `VerSaldo()`, que retorna o saldo atual.
// Crie um objeto dessa classe e faça algumas operações de depósito e saque.

using Exercicios;
using Exercicios.ContasBancarias;
using POO;

ContaBancaria account = new ContaBancaria();

account.Depositar(150);
account.Sacar(10);
Console.WriteLine($"Seu saldo é de: R$ {account.VerSaldo()}");

// 2. Classe Funcionario
// Crie uma classe `Funcionario` com:
// -Um atributo privado `_salario`.
// - Métodos `SetSalario(valor)` e `GetSalario()`
// - **SetSalario** → Modifica o salario com o valor fornecido pelo usuario
// - **GetSalario** → Retorna o Salario
// Crie um objeto, defina um salário e exiba o valor usando `GetSalario()`.

Funcionario salario = new Funcionario();

salario.SetSalario(1500);

Console.WriteLine($"O salario do funcionario é: R${salario.GetSalario():F2}");

// ### **Classe Retangulo**

// 3. Crie uma classe `Retangulo` com:
// -Dois atributos privados `_largura` e `_altura`.
// - Métodos `SetLargura(valor)`, `SetAltura(valor)`, `GetLargura()` e `GetAltura()`.
// - **SetLargura** → Modifica a _largura com o valor fornecido pelo usuario
// - **SetAltura** → Modifica a _altura com o valor fornecido pelo usuario
// - **GetLargura** → Retorna a Largura
// - **GetAltura** → Retorna a Altura
// - Um método público `CalcularArea()`, que retorna a área do retângulo.
// Crie um objeto, defina largura e altura, e exiba a área calculada.

Retangulo retangulo = new Retangulo();

retangulo.SetAltura(10);
retangulo.SetLargura(5);

Console.WriteLine($"A área do retangulo é {retangulo.CalcularArea()}");

// 4. Conta Corrente e Conta Poupança
// Utilizando a classe `ContaBancaria` criada no exercício 1, crie duas subclasses:
// - `ContaCorrente`: possui um método `CobrarTaxa()` que reduz o saldo em um valor fixo (ex: 10).
// - `ContaPoupanca`: possui um método `RenderJuros()`, que aumenta o saldo em 5%.
// Crie instâncias de ambas as classes, faça depósitos e utilize seus métodos específicos.

ContaCorrente taxa = new ContaCorrente();
taxa.Depositar(150);
taxa.CobrarTaxa(10);
taxa.VerSaldo();

Console.WriteLine($"O saldo atualizado da sua conta corrente é R${taxa.VerSaldo()}");


ContaPoupanca juros = new ContaPoupanca();

juros.Depositar(150);
juros.RenderJuros();
juros.VerSaldo();

Console.WriteLine($"O saldo atualizado da sua conta poupança é R${juros.VerSaldo()}");

// 5. Funcionário e Gerente
// Baseando - se na classe `Funcionario` do exercício 2, crie uma classe `Gerente`, que:
// -Herda `Funcionario`.
// - Possui um método `Bonificar()`, que aumenta o salário em 10%.
// Crie um objeto da classe `Gerente`, defina um salário, aplique a bonificação e exiba o salário atualizado.

Gerente bonificacao = new Gerente();

bonificacao.SetSalario(2500);
Console.WriteLine($"O salario do gerente com a bonificação é: R${bonificacao.Bonificar():F2}");