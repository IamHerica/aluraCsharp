using ByteBank.Funcionarios;
using System;


namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente(657, 75435);
            // Funcionario funcionario = null;

            FuncionarioAutenticavel carlos = null;

            

            Console.WriteLine(conta.Numero);
        }
    }
}
