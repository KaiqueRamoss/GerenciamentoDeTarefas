
namespace GerenciamentoDeTarefas.Entidades
{
    //Classe base para os usuários
    public abstract class Usuario
    {
        public string Nome { get;  set; }
        public string ChaveAcesso { get;  set; }

        public Usuario(string nome, string chaveAcesso)
        {
            Nome = nome;
            ChaveAcesso = chaveAcesso;
        }

        public static string LerSenha()
        {
            string senha = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                // Ignora a tecla Enter, para não exibi-la na senha
                if (key.Key != ConsoleKey.Enter)
                {
                    senha += key.KeyChar;
                    Console.Write("*");
                }
            } while (key.Key != ConsoleKey.Enter);

            Console.WriteLine();
            return senha;
        }
    }
}

