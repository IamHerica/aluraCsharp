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
                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
            


                ContaCorrente conta2 = new ContaCorrente(78, 986);
                conta2.Transferir(-10, conta2);
            }
            catch (ArgumentException e)
            {

                /*if (e.ParamName == "agencia")
                {
                    Console.WriteLine("blablabla");
                }*/

                Console.WriteLine("Argumento com problema! " + e.ParamName);
                //Console.WriteLine(e.StackTrace);
                Console.WriteLine("Erro!" + e.Message);
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException\n" + e.Message);
            }



            // Metodo();

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