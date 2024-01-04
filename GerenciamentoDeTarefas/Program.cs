using GerenciamentoDeTarefas.Entidades;
using GerenciamentoDeTarefas.Senha;

namespace GerenciamentoDeTarefas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Gerenciamento de Tarefas!");
            //switch case que seleciona o cargo
            bool sair = false;
            do
            {
                Console.WriteLine("Escolha o tipo de usuário:");
                Console.WriteLine("1. Tech Leader");
                Console.WriteLine("2. Desenvolvedor");
                Console.WriteLine("0. Sair");

                int opcao;
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        AcessarComoTechLeader();
                        break;
                    case 2:
                        AcessarComoDesenvolvedor();
                        break;
                    case 0:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                        break;
                }

            } while (!sair);
        }

        static void AcessarComoTechLeader()
        {
            Console.WriteLine("Acessando como Tech Leader...");
            Autenticacao autenticacao = new Autenticacao();

            Console.WriteLine("Por favor, faça login.");

            bool loggedIn = false;

            do
            {
                Console.Write("Usuário: ");
                string inputUsuario = Console.ReadLine();

                Console.Write("Senha: ");
                string inputSenha = LerSenha();

                loggedIn = autenticacao.FazerLogin(inputUsuario, inputSenha);

                if (!loggedIn)
                {
                    Console.WriteLine("Credenciais inválidas. Tente novamente.");
                }

            } while (!loggedIn);

            Console.WriteLine("Login bem-sucedido! Bem-vindo, Tech Leader!");
            
            TechLeader.ExibirMenuTechLeader();
        }

        static void AcessarComoDesenvolvedor()
        {
            Console.WriteLine("Acessando como Desenvolvedor...");
            Autenticacao autenticacao = new Autenticacao();

            Console.WriteLine("Por favor, faça login.");

            bool loggedIn = false;

            do
            {
                Console.Write("Usuário: ");
                string inputUsuario = Console.ReadLine();

                Console.Write("Senha: ");
                string inputSenha = LerSenha();

                loggedIn = autenticacao.FazerLogin(inputUsuario, inputSenha);

                if (!loggedIn)
                {
                    Console.WriteLine("Credenciais inválidas. Tente novamente.");
                }

            } while (!loggedIn);

            Console.WriteLine("Login bem-sucedido! Bem-vindo, Desenvolvedor!");

            Desenvolvedor.ExibirMenuDesenvolvedor();
        }

        static string LerSenha()
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

