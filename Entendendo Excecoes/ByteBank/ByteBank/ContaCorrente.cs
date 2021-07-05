using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static double TaxaOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; } //é uma caracteristca da classe, por isso é static
        public int Agencia { get; }
        public int SaquesNaoPermitidos { get; private set; }
        public int TransferenciaNaoPermitidos { get; private set; }


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
            if (numeroAgencia <= 0)
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
            if (valor < 0)
            {
                throw new ArgumentException("Valor negativo!", nameof(valor));
            }
            if (_saldo < valor)
            {
                SaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor); //criando uma nova exceção
            }

            _saldo -= valor;

        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor invalido para a tranferencia!", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                TransferenciaNaoPermitidos++;
                throw new Exception("Operação não realizada! ", ex);
            }

            contaDestino.Depositar(valor);
        }
    }
}