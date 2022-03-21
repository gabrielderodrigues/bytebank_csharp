using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriel = new Cliente();

            gabriel.nome = "Gabriel";
            gabriel.profissao = "Desenvolvedor Angular";
            gabriel.cpf = "124.756.882.01";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = gabriel;
            conta.titular.nome = gabriel.nome;
            conta.saldo = 500;
            conta.numeroConta = 53;
            conta.numeroAgencia = 532331;

            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(gabriel.profissao);

            Console.ReadLine();
        }
    }
}
