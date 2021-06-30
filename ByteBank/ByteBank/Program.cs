using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
           // CalcularBonificacao();
            UsarSistema();

        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("222.222.222-22");
            roberta.Nome = "Roberta";
            roberta.Senha = "abc";

            GerenteDeConta camila = new GerenteDeConta("444.444.444-44");
            camila.Nome = "Camila";
            camila.Senha = "123";

            ParceiroComercial parceiro = new ParceiroComercial();

            parceiro.Senha = "12345";

            sistemaInterno.Logar(parceiro, "12345");
            sistemaInterno.Logar(camila, "123");
            sistemaInterno.Logar(roberta, "abc");

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer pedro = new Designer("111.111.111-11");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("222.222.222-22");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("333.333.333-33");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("444.444.444-44");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("555.555.555-44");
            guilherme.Nome = "Guilherme";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);
            gerenciador.Registrar(guilherme);

            Console.WriteLine("Total de bonificacoes do mês: " + gerenciador.GetTotalBonificacao());

        }
    }
}
