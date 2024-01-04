using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeTarefas.Senha
{
    internal class Autenticacao
    {
        private string usuario = "admin";
        private string senha = "1234";

        public bool FazerLogin(string inputUsuario, string inputSenha)
        {
            return inputUsuario == usuario && inputSenha == senha;
        }

    }
}
