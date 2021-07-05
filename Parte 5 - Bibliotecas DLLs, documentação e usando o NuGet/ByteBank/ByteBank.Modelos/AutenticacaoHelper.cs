using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos
{//helper porque é uma classe que ajuda as outras
    //classe visivel apenas na biblioteca ByteBank.Modelos(internal)
    internal class AutenticacaoHelper 
    {
        public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaTentativa == senhaVerdadeira;
        }
    }
}
