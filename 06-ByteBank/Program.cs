using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Gabriel";
            cliente.CPF = "343.345.788-98";
            cliente.Profissao = "Desenvolvedor";

            conta.Saldo = -10;
            conta.Saldo = 100;
            conta.titular = cliente;

            Console.WriteLine(conta.titular.Nome);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
