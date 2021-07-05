using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args) //excecoes podem ser tratadas no Main
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(98, 74640);

                ContaCorrente conta2 = new ContaCorrente(78, 986);

                //conta.Transferir(1000, conta2);
                conta.Sacar(80000);

            } catch (OperacaoFinanceiraException e) //tanto transferencia como saque
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);



               //acessando para verificar o que acontece no sistema
               // Console.WriteLine("\n\n\n\nInformações da INNER EXCEPTION (exceção interna):");
               // Console.WriteLine("\n\n" + e.InnerException.Message);
               // Console.WriteLine("\n" + e.InnerException.StackTrace);
            }

        }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão = " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                throw;//passar adiante essa excecao
            }

        }
    }





}