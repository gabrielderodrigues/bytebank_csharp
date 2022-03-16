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

            ContaCorrente contaDaVivian = new ContaCorrente();
            contaDaVivian.nomeTitular = "Vivian";

            contaDoGabriel.Transferir(500, contaDaVivian);
            Console.WriteLine("Saldo Gabriel: " + contaDoGabriel.saldo);
            Console.WriteLine("Saldo Vivian: " + contaDaVivian.saldo);

            contaDaVivian.Transferir(250, contaDoGabriel);
            Console.WriteLine("Saldo Gabriel: " + contaDoGabriel.saldo);
            Console.WriteLine("Saldo Vivian: " + contaDaVivian.saldo);

            Console.ReadLine();
        }
    }
}
