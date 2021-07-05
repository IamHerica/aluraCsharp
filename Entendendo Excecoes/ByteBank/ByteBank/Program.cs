using System;
using System.Collections.Generic;
using System.IO;
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
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("CATCH NO MAIN");
            }

            Console.WriteLine("Execução finalizada.");

        }

        private static void CarregarContas()
        {
            //using testa se é nula, é como se fosse todo o try e finally. além disso, quando terminar ele já chama o dispose(fechar arquivo)
            using (LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt")) //deve implementar a interface IDisposable
            {
                leitor.LerProximaLinha();
            }






            //LeitorDeArquivos leitor = new LeitorDeArquivos("contas.txt");

            //try
            //{

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();

            //}
            //catch (IOException)
            //{

            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada");
            //} finally
            //{



            //    leitor.Fechar();
            //}

        }


        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(98, 74640);

                ContaCorrente conta2 = new ContaCorrente(78, 986);

                //conta.Transferir(1000, conta2);
                conta.Sacar(80000);

            }
            catch (OperacaoFinanceiraException e) //tanto transferencia como saque
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