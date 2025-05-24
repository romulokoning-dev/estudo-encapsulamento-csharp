# Projeto ContaBancaria

## Descrição

Este projeto é uma implementação básica de uma classe `ContaBancaria` em C#, que simula operações bancárias simples como depósito, saque e consulta de saldo.

A ideia principal é praticar conceitos de Programação Orientada a Objetos (POO), encapsulamento e métodos em C#.

## Funcionalidades

- Depositar valores positivos na conta.
- Realizar saques, respeitando o saldo disponível.
- Exibir o saldo atual da conta.

## Como usar

No método `Main` da classe `Program`, criamos um objeto `ContaBancaria` e testamos os métodos:

```csharp
ContaBancaria conta = new ContaBancaria();
conta.Depositar(100);
conta.ExibirSaldo();
conta.Saque(200);
conta.ExibirSaldo();
conta.Saque(50);
conta.ExibirSaldo();
