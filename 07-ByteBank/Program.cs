using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(876, 86712540);

            ContaCorrente contaGabriel = new ContaCorrente(454, 454223123);

            ContaCorrente contaPaulo = new ContaCorrente(454, 454223123);

            ContaCorrente contaSopa = new ContaCorrente(454, 454223123);

            Console.WriteLine($"Total de contas criadas até o momento é de: {ContaCorrente.TotalDeContasCriadas}");

            Console.ReadLine();
        }
    }
}
