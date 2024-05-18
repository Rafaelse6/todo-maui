using ToDoApp.Constants;
using ToDoApp.Models;
using ToDoApp.Services;

namespace ToDoApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            var tarefaService = new DatabaseServico<Tarefa>(Db.DB_PATH);
            var tarefa = new Tarefa()
            {
                Titulo = "Lavar o carro",
                Descricao = "Pegar o carro na garagem e levar no lava rápido",
                Status = Enums.Status.Backlog,
                UsuarioId = UsuariosServico.Instancia().Todos()[0].Id,
            };

            await tarefaService.IncluirAsync(tarefa);

            var quantidade = await tarefaService.QuantidadeAsync();

            count++;

            if (count == 1)
                CounterBtn.Text = $"Cliquei aqui {count} vezes - E tenho {quantidade} cadastrado no SQLite";
            else
                CounterBtn.Text = $"Cliquei aqui {count} vezes - E tenho {quantidade} cadastrado no SQLite";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
