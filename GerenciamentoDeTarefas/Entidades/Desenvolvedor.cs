
using System.IO;
using GerenciamentoDeTarefas.Senha;
using Newtonsoft.Json;

namespace GerenciamentoDeTarefas.Entidades
{
    // Classe para os Desenvolvedores
    public class Desenvolvedor : Usuario
    {

        public List<Tarefa> Tarefas { get; set; }

        public Desenvolvedor(string nome, string chaveAcesso)
            : base(nome, chaveAcesso)
        {
            Tarefas = new List<Tarefa>();
        }

        public static void AcessarComoDesenvolvedor(Desenvolvedor desenvolvedor)
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

            Desenvolvedor.ExibirMenuDesenvolvedor(desenvolvedor);
        }


        public static void ExibirMenuDesenvolvedor(Desenvolvedor desenvolvedor)
        {
            bool sair = false;

            do
            {
                Console.WriteLine("\nMenu do Desenvolvedor:");
                Console.WriteLine("1. Criar Tarefa");
                Console.WriteLine("2. Visualizar Minhas Tarefas");
                Console.WriteLine("0. Voltar");

                int opcao;
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        CriarTarefaDesenvolvedor(desenvolvedor);
                        break;
                    case 2:
                        VisualizarMinhasTarefas(desenvolvedor);
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

        
        static void CriarTarefaDesenvolvedor(Desenvolvedor desenvolvedor)
        {
            Console.WriteLine("Opção selecionada: Criar Tarefa");
            Console.WriteLine("Digite a descrição da nova tarefa:");
            string descricao = Console.ReadLine();
            Console.WriteLine("Digite o responsavel da nova tarefa:");
            string responsavel = Console.ReadLine();

            // Supondo que o status seja fornecido de alguma maneira, como uma escolha do usuário
            StatusTarefa status = StatusTarefa.EmAnalise; // Por exemplo, definindo como Pendente por padrão

            desenvolvedor.CriarTarefa(descricao, status, responsavel);
        }

        public void CriarTarefa(string descricao, StatusTarefa status, string responsavel)
        {
            // Lógica para criar uma nova tarefa automaticamente atribuída ao desenvolvedor
            Tarefa novaTarefa = new Tarefa(Tarefas.Count + 1, descricao, status, responsavel);
            Tarefas.Add(novaTarefa);
        }

        static void VisualizarMinhasTarefas(Desenvolvedor desenvolvedor)
        {
            Console.WriteLine($"Tarefas:");
            foreach (var tarefa in desenvolvedor.Tarefas)
            {
                Console.WriteLine($"ID: {tarefa.Id} - Descrição: {tarefa.Descricao} - Status: {tarefa.Status}");
            }
        }
        public void MostrarInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Chave de Acesso: {ChaveAcesso}");
        }

        public static void LerDevs()
        {
            // Caminho do arquivo JSON
            string caminhoArquivo = "E:\\Users\\kaiqu\\Desktop\\Projeto Individual\\GerenciamentoDeTarefas\\GerenciamentoDeTarefas\\Entidades\\desenvolvedores.json";

            // Lê o conteúdo do arquivo JSON
            string json = File.ReadAllText(caminhoArquivo);

            // Converte o JSON para uma lista de objetos Desenvolvedor
            List<Desenvolvedor> desenvolvedores = JsonConvert.DeserializeObject<List<Desenvolvedor>>(json);

            // Mostra as informações dos desenvolvedores (apenas para demonstração)
            Console.WriteLine("Desenvolvedores adicionados:");

            foreach (var dev in desenvolvedores)
            {
                dev.MostrarInformacoes();
            }
        }


      

        // Outros métodos para manipular tarefas específicas do desenvolvedor
    }
}
