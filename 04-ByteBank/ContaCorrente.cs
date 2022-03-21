using System;

namespace _05_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
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

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                Console.WriteLine("Não foi possível realizar a transferência pois você não possui saldo suficiente.");
            }
            else
            {
                this.saldo -= valor;
                contaDestino.saldo += valor;
                Console.WriteLine("Transferência no valor de R$" + valor + " realizada com sucesso!");
            }
        }
    }
}