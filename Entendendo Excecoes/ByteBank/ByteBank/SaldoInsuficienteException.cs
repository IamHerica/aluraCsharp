using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class SaldoInsuficienteException : Exception
    {

        public SaldoInsuficienteException()
        {

        }
        //criando uma mensagem(argumento) para explicar o exception
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {
        }
    }
}
