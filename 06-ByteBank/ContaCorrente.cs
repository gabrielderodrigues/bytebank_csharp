using System;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public Cliente titular { get; set; }

        private double saldo;

        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                saldo = value;
            }
        }

        //public double GetSaldo()
        //{
        //    return saldo;
        //}

        //public void SetSaldo(double saldo)
        //{
        //    if (saldo < 0)
        //    {
        //        Console.WriteLine("Não foi possível definir um saldo.");
        //    }
        //    else
        //    {
        //        this.saldo = saldo;
        //    }
        //}

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