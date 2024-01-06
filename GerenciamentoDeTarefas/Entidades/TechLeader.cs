

using GerenciamentoDeTarefas.Senha;

namespace GerenciamentoDeTarefas.Entidades
{
    // Classe para o Tech Leader
    public class TechLeader : Usuario
    {
        public List<Tarefa> Tarefas { get; set; }

        public TechLeader(string nome, string chaveAcesso)
            : base(nome, chaveAcesso)
        {
            Tarefas = new List<Tarefa>();
        }

        public static void AcessarComoTechLeader(TechLeader techLeader)
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

            TechLeader.ExibirMenuTechLeader(techLeader);
        }

        public static void ExibirMenuTechLeader(TechLeader techLeader)
        {
            bool sair = false;

            do
            {
                Console.WriteLine("\nMenu do Tech Leader:");
                Console.WriteLine("1. Criar Tarefa");
                Console.WriteLine("2. Assumir Tarefa");
                Console.WriteLine("3. Atribuir Responsável");
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
                        CriarTarefaTechLeader(techLeader);
                        break;
                    case 2:
                        AssumirTarefa();
                        break;
                    case 3:
                        AtribuirResponsavel();
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

        // Métodos de operações do Tech Leader

        static void CriarTarefaTechLeader(TechLeader techLeader)
        {
            Console.WriteLine("Opção selecionada: Criar Tarefa");
            Console.WriteLine("Digite a descrição da nova tarefa:");
            string descricao = Console.ReadLine();

            // Supondo que o status seja fornecido de alguma maneira, como uma escolha do usuário
            StatusTarefa status = StatusTarefa.EmAnalise; // Por exemplo, definindo como Pendente por padrão

            techLeader.CriarTarefa(descricao, status);
        }
        public void CriarTarefa(string descricao, StatusTarefa status)
        {
            // Lógica para criar uma nova tarefa automaticamente atribuída ao desenvolvedor
            Tarefa novaTarefa = new Tarefa(Tarefas.Count + 1, descricao, status, Nome);
            Tarefas.Add(novaTarefa);
        }
        static void AssumirTarefa()
        {
            Console.WriteLine("Opção selecionada: Assumir Tarefa");
            // Adicionar lógica para assumir uma tarefa
        }

        static void AtribuirResponsavel()
        {
            Console.WriteLine("Opção selecionada: Atribuir Responsável");
            // Adicionar lógica para atribuir responsável a uma tarefa
        }


        public void CriarTarefa(string descricao, StatusTarefa status, string responsavel)
        {
            // Lógica para criar uma nova tarefa e adicioná-la à lista de tarefas
            Tarefa novaTarefa = new Tarefa(Tarefas.Count + 1, descricao, status, responsavel);
            Tarefas.Add(novaTarefa);
        }
        public void AssumirTarefa(int idTarefa)
        {
            // Lógica para o Tech Leader assumir uma tarefa
            Tarefa tarefa = Tarefas.Find(t => t.Id == idTarefa);
            if (tarefa != null)
            {
                // Lógica para assumir a tarefa
                tarefa.Responsavel = Nome;
                tarefa.Status = StatusTarefa.EmAnalise;
            }
            else
            {
                throw new Exception("Tarefa não encontrada.");
            }
        }

        public void AtribuirResponsavel(int idTarefa, string novoResponsavel)
        {
            // Lógica para o Tech Leader atribuir um novo responsável a uma tarefa
            Tarefa tarefa = Tarefas.Find(t => t.Id == idTarefa);
            if (tarefa != null)
            {
                // Lógica para atribuir um novo responsável à tarefa
                tarefa.Responsavel = novoResponsavel;
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }

        public void VisualizarEstatisticas()
        {
            // Lógica para exibir estatísticas das tarefas
            // Por exemplo:
            // Quantidade de tarefas em cada status (Em Atraso, Concluídas, etc.)
            // Outras estatísticas desejadas
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
}

