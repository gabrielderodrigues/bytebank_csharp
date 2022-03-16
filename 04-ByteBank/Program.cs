using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoGabriel = new ContaCorrente();
            contaDoGabriel.nomeTitular = "Gabriel";

            //contaDoGabriel.saldo = 100;
            //Console.WriteLine(contaDoGabriel.saldo);
            //contaDoGabriel.Sacar(50);
            //Console.WriteLine(contaDoGabriel.saldo);

            contaDoGabriel.Depositar(500);
            Console.WriteLine(contaDoGabriel.saldo);

            Console.ReadLine();
        }
    }
}
