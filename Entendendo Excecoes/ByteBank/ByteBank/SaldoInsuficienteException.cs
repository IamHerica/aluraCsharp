using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {

        public double Saldo { get; } //sem set pq o valor nunca vai mudar
        public double ValorSaque { get; } //o c# ja faz o readonly e o seter privado

        public SaldoInsuficienteException()
        {

        }
        // o this esta chamando o construtor que esta logo a baixo, que esta passando a mensagem
        public SaldoInsuficienteException(double saldo, double valorSaque) : this ("Tentativa de saque do valor de " + valorSaque + " em uma conta com saldo insuficiente.")
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        //criando uma mensagem(argumento) para explicar o exception
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {
        }

        //criando para boas praticas
        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna)
        {

        }
    }
}
