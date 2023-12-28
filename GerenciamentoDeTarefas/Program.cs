namespace GerenciamentoDeTarefas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
//            using System;
//            using System.Collections.Generic;

//// Enum para representar o status da tarefa
//public enum StatusTarefa
//        {
//            EmAtraso,
//            Concluida,
//            Abandonada,
//            ComImpedimento,
//            EmAnalise,
//            AprovacaoParaInicio
//        }

//        // Classe para representar uma tarefa
//        public class Tarefa
//        {
//            public int Id { get; set; }
//            public string Descricao { get; set; }
//            public StatusTarefa Status { get; set; }
//            public DateTime DataCriacao { get; set; }
//            public DateTime? DataConclusao { get; set; }
//            public string Responsavel { get; set; }
//            // Outros campos necessários para as tarefas

//            public Tarefa(int id, string descricao, StatusTarefa status, string responsavel)
//            {
//                Id = id;
//                Descricao = descricao;
//                Status = status;
//                Responsavel = responsavel;
//                DataCriacao = DateTime.Now;
//            }
//        }

//        // Classe base para os usuários
//        public abstract class Usuario
//        {
//            public string Nome { get; set; }
//            public string ChaveAcesso { get; set; }

//            public Usuario(string nome, string chaveAcesso)
//            {
//                Nome = nome;
//                ChaveAcesso = chaveAcesso;
//            }
//        }

//        // Classe para o Tech Leader
//        public class TechLeader : Usuario
//        {
//            public List<Tarefa> Tarefas { get; set; }

//            public TechLeader(string nome, string chaveAcesso)
//                : base(nome, chaveAcesso)
//            {
//                Tarefas = new List<Tarefa>();
//            }

//            public void CriarTarefa(string descricao, StatusTarefa status, string responsavel)
//            {
//                // Lógica para criar uma nova tarefa e adicioná-la à lista de tarefas
//                Tarefa novaTarefa = new Tarefa(Tarefas.Count + 1, descricao, status, responsavel);
//                Tarefas.Add(novaTarefa);
//            }

//            // Outros métodos para manipular tarefas, como assumir, alterar responsável, etc.
//        }

//        // Classe para os Desenvolvedores
//        public class Desenvolvedor : Usuario
//        {
//            public List<Tarefa> Tarefas { get; set; }

//            public Desenvolvedor(string nome, string chaveAcesso)
//                : base(nome, chaveAcesso)
//            {
//                Tarefas = new List<Tarefa>();
//            }

//            public void CriarTarefa(string descricao, StatusTarefa status)
//            {
//                // Lógica para criar uma nova tarefa automaticamente atribuída ao desenvolvedor
//                Tarefa novaTarefa = new Tarefa(Tarefas.Count + 1, descricao, status, Nome);
//                Tarefas.Add(novaTarefa);
//            }

//            // Outros métodos para manipular tarefas específicas do desenvolvedor
        }

    }
}
}
