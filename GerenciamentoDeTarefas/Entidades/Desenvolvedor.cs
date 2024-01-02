using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void CriarTarefa(string descricao, StatusTarefa status)
        {
            // Lógica para criar uma nova tarefa automaticamente atribuída ao desenvolvedor
            Tarefa novaTarefa = new Tarefa(Tarefas.Count + 1, descricao, status, Nome);
            Tarefas.Add(novaTarefa);
        }

        // Outros métodos para manipular tarefas específicas do desenvolvedor
    }
}
