using SQLite;
using ToDoApp.Enums;

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
        public Status Status { get; set; }
    }
}
