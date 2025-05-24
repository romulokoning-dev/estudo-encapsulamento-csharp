using System;
using System.ComponentModel.DataAnnotations.Schema;

class ContaBancaria // Crio a classe ContaBancaria
{
    private double saldo; // Uso uma variável 'private' para impedir que outras classes mudem o saldo

    public void Depositar(double Deposito) // Crio o método depositar como argumento válido para modificar o saldo
    {
        if (Deposito > 0) // Verifico se o depósito não é um número negativo ou valor zero.
        {
            saldo += Deposito; // Adiciono o valor do depósito ao saldo
            Console.WriteLine($"Depósito de {Deposito}R$ realizado com sucesso."); // Aqui dou a mensagem de confirmação do depósito realizado com sucesso.
        }
        else // Caso valor do depósito seja negativo ou zero:
        {
            Console.WriteLine("O valor do depósito deve ser maior que zero.");  // Mensagem de erro
        }
    }

    public void Saque(double Saque) // Agora crio o Método Saque, que também é um argumento válido para alterar o valor do saldo.
    {
        if (Saque > saldo) // Verifico se o valor do saque não é maior que o saldo.
        {
            Console.WriteLine($"Você não pode sacar um valor maior que o saldo! Saldo atual:R${saldo}"); // Mensagem de erro
        }
        else // Caso seja menor ou igual ao valor do saldo:
        {
            saldo -= Saque; // O saldo tem valor reduzido pelo saque.
            Console.WriteLine($"Saque de R${Saque} realizado com sucesso."); // Mensagem de confirmação.
        }
    }

    public void ExibirSaldo() // Método para exibir o valor do saldo.
    {
        Console.WriteLine($"Seu saldo é:R${saldo}"); // Interpolação para exibir o valor da variável saldo.
    }

}

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria(); // Crio o objeto da classe ContaBancaria
        conta.Depositar(100); // Uso o método depósito e atribuo o valor dele a 100
        conta.ExibirSaldo(); // Mostro o saldo com o novo valor de depósito
        conta.Saque(200); // Tento sacar 200, que é maior que o valor do atual saldo, então a mensagem de erro aparece no console.
        conta.ExibirSaldo(); // Exibo o saldo novamente
        conta.Saque(50); // Agora faço um saque dentro dos requisitos previamente escritos
        conta.ExibirSaldo(); // Exibo o novo valor do saldo. 

    }
}
