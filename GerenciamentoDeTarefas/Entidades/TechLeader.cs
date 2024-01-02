using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                public void CriarTarefa(string descricao, StatusTarefa status, string responsavel)
                {
                    // Lógica para criar uma nova tarefa e adicioná-la à lista de tarefas
                    Tarefa novaTarefa = new Tarefa(Tarefas.Count + 1, descricao, status, responsavel);
                    Tarefas.Add(novaTarefa);
                }

                // Outros métodos para manipular tarefas, como assumir, alterar responsável, etc.
            }
}
