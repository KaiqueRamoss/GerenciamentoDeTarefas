using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosSistema
{
    public class Tarefa
    {
        // Classe para representar uma tarefa
        public int Id { get; set; }
        public string Descricao { get; set; }
        public StatusTarefa Status { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataConclusao { get; set; }
        public string Responsavel { get; set; }
        // Outros campos necessários para as tarefas

        public Tarefa(int id, string descricao, StatusTarefa status, string responsavel)
        {
            Id = id;
            Descricao = descricao;
            Status = status;
            Responsavel = responsavel;
            DataCriacao = DateTime.Now;
        }
    }
    // Enum para representar o status da tarefa
    public enum StatusTarefa
    {
        EmAtraso = 0,
        Concluida = 1,
        Abandonada = 2,
        ComImpedimento = 3,
        EmAnalise = 4,
        AprovacaoParaInicio = 5
    }
}

