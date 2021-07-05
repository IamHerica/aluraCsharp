using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ByteBank
{
    class LeitorDeArquivos : IDisposable //assinando o contrato com a interface 
    {

        public string Arquivo { get; }

        public LeitorDeArquivos(string arquivo)
        {
            Arquivo = arquivo;

           // throw new FileNotFoundException();
            
            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }
        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");


            throw new IOException();


            return "Linha do arquivo";
        }

        //metodo que tem a funcao de liberar os recursos, fechar o arquivo
        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo");
        }
    }
}
