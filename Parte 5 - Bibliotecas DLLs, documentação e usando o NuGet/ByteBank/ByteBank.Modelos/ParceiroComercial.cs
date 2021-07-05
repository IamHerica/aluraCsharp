using ByteBank.Modelos;
using ByteBank.Sistemas;

namespace ByteBank
{
    class ParceiroComercial : IAutenticavel
    { 
        private AutenticacaoHelper _autenticacacaoHelper = new AutenticacaoHelper();
        public string Senha { get; set; }
       

        public bool Autenticar(string senha)
        {
            return _autenticacacaoHelper.CompararSenhas(Senha, senha);
        }


    }
}
