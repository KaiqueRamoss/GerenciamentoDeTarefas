
namespace GerenciamentoDeTarefas.Entidades
{
    //Classe base para os usuários
    public abstract class Usuario
    {
        public string Nome { get; set; }
        public string ChaveAcesso { get; set; }

        public Usuario(string nome, string chaveAcesso)
        {
            Nome = nome;
            ChaveAcesso = chaveAcesso;
        }
    }
}
