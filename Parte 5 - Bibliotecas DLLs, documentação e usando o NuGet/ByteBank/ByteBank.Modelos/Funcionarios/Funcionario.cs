using System;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {

        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();
        
        //para o getBonificacao seja visivel na dll e para quem tenta derivar (internal protected)
        internal protected abstract double GetBonificacao(); //classes filhas que irao implementar 
       


    }
}
