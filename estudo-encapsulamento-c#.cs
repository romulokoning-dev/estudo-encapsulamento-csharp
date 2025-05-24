using System;
using System.ComponentModel.DataAnnotations.Schema;

class ContaBancaria
{
    private double saldo;

    public void Depositar(double Deposito)
    {
        if (Deposito > 0)
        {
            saldo += Deposito;
            Console.WriteLine($"Depósito de {Deposito}R$ realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("O valor do depósito deve ser maior que zero.");
        }
    }

    public void Saque(double Saque)
    {
        if (Saque > saldo)
        {
            Console.WriteLine($"Você não pode sacar um valor maior que o saldo! Saldo atual:R${saldo}");
        }
        else
        {
            saldo -= Saque;
            Console.WriteLine($"Saque de R${Saque} realizado com sucesso.");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Seu saldo é:R${saldo}");
    }

}

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria();
        conta.Depositar(100);
        conta.ExibirSaldo();
        conta.Saque(200);
        conta.ExibirSaldo();
        conta.Saque(50);
        conta.ExibirSaldo();

    }
}
