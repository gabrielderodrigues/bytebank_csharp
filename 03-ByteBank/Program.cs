using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoGabriel = new ContaCorrente();
            contaDoGabriel.nomeTitular = "Gabriel";
            contaDoGabriel.numeroAgencia = 004;
            contaDoGabriel.numeroConta = 004564;

            ContaCorrente contaDoGabrielOliveira = new ContaCorrente();
            contaDoGabrielOliveira.nomeTitular = "Gabriel";
            contaDoGabrielOliveira.numeroAgencia = 004;
            contaDoGabrielOliveira.numeroConta = 004564;

            Console.WriteLine(contaDoGabriel == contaDoGabrielOliveira);
            // É false pois estão armazenadas em endereços de memória diferente

            contaDoGabriel = contaDoGabrielOliveira;
            Console.WriteLine(contaDoGabriel == contaDoGabrielOliveira);
            // É true pois apontam para o mesmo lugar na memória do computador

            contaDoGabriel.saldo = 300;
            Console.WriteLine(contaDoGabriel.saldo);
            Console.WriteLine(contaDoGabrielOliveira.saldo);

            Console.ReadLine();
        }
    }
}
