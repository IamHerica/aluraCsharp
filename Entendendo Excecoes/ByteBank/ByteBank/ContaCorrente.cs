using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static double TaxaOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; } //é uma caracteristca da classe, por isso é static
        public int Agencia { get; }


        //private readonly int _numero; //Apenas leitura, impossibilitando atribuir outro numero
        //isso ai é igual isso aqui:
        public int Numero { get; }
     

        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int numeroAgencia, int numeroConta)
        {
            //lancando excecoes personalizadas
            if(numeroAgencia <= 0)
            {  
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(numeroAgencia));
            }
            if (numeroConta <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numeroConta));
            }

            Agencia = numeroAgencia;
            Numero = numeroConta;
           
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }


        public void Sacar(double valor)
        {
            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException("Saldo insuficente para  saque no valor de: " + valor); //criando uma nova exceção
            }

            _saldo -= valor;
          
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}