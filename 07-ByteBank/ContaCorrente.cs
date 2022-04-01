using System;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas 
        { 
            get; 
            private set; 
        }

        private int _agencia;
        public int Agencia 
        { 
            get
            {
                return _agencia;
            }
            set
            {
                if (_agencia <= 0)
                {
                    return;
                }

                _agencia = value;
            } 
        }

        public int Numero { get; set; }

        public Cliente titular { get; set; }

        private double _saldo;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
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

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            // Não é necessário o ContaCorrente
            ContaCorrente.TotalDeContasCriadas++;
        }

        public void Sacar(double valor)
        {
            if (this._saldo <= valor)
            {
                Console.WriteLine("Não foi possível realizar o saque pois você não tem saldo suficiente.");
            }
            else
            {
                this._saldo -= valor;
                Console.WriteLine("Você sacou R$" + valor);
                Console.WriteLine("Seu saldo atual é R$" + this._saldo);
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
            Console.WriteLine("Você depositou R$" + valor);
            Console.WriteLine("Seu saldo atual é de R$" + this._saldo);
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                Console.WriteLine("Não foi possível realizar a transferência pois você não possui saldo suficiente.");
            }
            else
            {
                this._saldo -= valor;
                contaDestino._saldo += valor;
                Console.WriteLine("Transferência no valor de R$" + valor + " realizada com sucesso!");
            }
        }
    }
}