using System;

namespace ByteBank.SistemaInternal
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(123, 455667);
            Console.WriteLine(conta.Saldo);
        }
    }
}
