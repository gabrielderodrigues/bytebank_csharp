using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoGabriel = new ContaCorrente();
            contaDoGabriel.nomeTitular = "Gabriel";
            contaDoGabriel.numeroAgencia = 001;
            contaDoGabriel.numeroConta = 0010504;
            contaDoGabriel.saldo = 200;

            Console.WriteLine(contaDoGabriel.nomeTitular);
            Console.WriteLine("Agência: " + contaDoGabriel.numeroAgencia);
            Console.WriteLine("Número: " + contaDoGabriel.numeroConta);
            Console.WriteLine("Saldo: " + contaDoGabriel.saldo);

            Console.ReadLine();
        }
    }
}
