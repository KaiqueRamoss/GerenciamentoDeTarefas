

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


        public static void ExibirMenuTechLeader()
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
                        CriarTarefa();
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
        static void CriarTarefa()
        {
            Console.WriteLine("Opção selecionada: Criar Tarefa");
            // Adicionar lógica para criar uma nova tarefa
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

        public void AdicionarDesenvolvedor(Desenvolvedor desenvolvedor)
        {
            // Lógica para adicionar um desenvolvedor à lista de desenvolvedores
            // Esta lógica pode envolver o armazenamento dos desenvolvedores em uma lista
            // no Tech Leader ou em algum local centralizado.
        }

        // Outros métodos para manipular tarefas
    }
}

