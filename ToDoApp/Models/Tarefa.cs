using SQLite;
using ToDoApp.Enums;
using ToDoApp.Services;

namespace ToDoApp.Models
{
    public class Tarefa
    {
        public Tarefa()
        {
            this.DataCriacao = DateTime.Now;
            this.DataAtualizacao = DateTime.Now;
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public int UsuarioId { get; set; }
        public string NomeUsuario
        {
            get
            {
                if (this.UsuarioId == 0) return "Sem Usuário";
                return UsuariosServico.Instancia().Todos().Find(u => u.Id == this.UsuarioId)?.Nome;
            }
        }
        public Status Status { get; set; }
    }
}
