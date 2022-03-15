using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.nomeTitular = "Gabriel";

            Console.WriteLine("Nome: " + conta.nomeTitular);
            Console.WriteLine("Saldo: " + conta.saldo);

            Console.ReadLine();
        }
    }
}
