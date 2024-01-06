using GerenciamentoDeTarefas.Entidades;
using GerenciamentoDeTarefas.Senha;

namespace GerenciamentoDeTarefas
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nome = null;
            string chaveAcesso = null;
            Desenvolvedor desenvolvedor = new Desenvolvedor(nome,chaveAcesso);
            TechLeader techLeader = new TechLeader(nome, chaveAcesso); 

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
                        TechLeader.AcessarComoTechLeader(techLeader);
                        break;
                    case 2:
                        Desenvolvedor.AcessarComoDesenvolvedor(desenvolvedor);
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
        }
    }


