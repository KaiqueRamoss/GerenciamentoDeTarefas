

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

        public static void ExibirMenuDesenvolvedor()
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
                        CriarTarefaDesenvolvedor();
                        break;
                    case 2:
                        VisualizarMinhasTarefas();
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

        
        static void CriarTarefaDesenvolvedor()
        {
            Console.WriteLine("Opção selecionada: Criar Tarefa");
            // Adicionar lógica para um desenvolvedor criar uma nova tarefa

        }

        public void CriarTarefa(string descricao, StatusTarefa status)
        {
            // Lógica para criar uma nova tarefa automaticamente atribuída ao desenvolvedor
            Tarefa novaTarefa = new Tarefa(Tarefas.Count + 1, descricao, status, Nome);
            Tarefas.Add(novaTarefa);
        }

        static void VisualizarMinhasTarefas()
        {
            Console.WriteLine("Opção selecionada: Visualizar Minhas Tarefas");
            // Adicionar lógica para um desenvolvedor visualizar suas tarefas
        }


      

        // Outros métodos para manipular tarefas específicas do desenvolvedor
    }
}
