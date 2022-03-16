using System;

public class ContaCorrente
{
    public string nomeTitular;
    public int numeroAgencia;
    public int numeroConta;
    public double saldo;

    public void Sacar(double valor)
    {
        if (this.saldo <= valor)
        {
            Console.WriteLine("Não foi possível realizar o saque pois você não tem saldo suficiente.");
        }
        else
        {
            this.saldo -= valor;
            Console.WriteLine("Você sacou R$" + valor);
            Console.WriteLine("Seu saldo atual é R$" + this.saldo);
        }
    }

    public void Depositar(double valor)
    {
        this.saldo += valor;
        Console.WriteLine("Você depositou R$" + valor);
        Console.WriteLine("Seu saldo atual é de R$" + this.saldo);
    }
}