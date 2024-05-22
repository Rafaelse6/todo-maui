using ToDoApp.Constants;
using ToDoApp.Models;
using ToDoApp.Services;

namespace ToDoApp
{
    public partial class MainPage : ContentPage
    {

        DatabaseServico<Tarefa> _tarefaService;

        public MainPage()
        {
            InitializeComponent();
            _tarefaService = new DatabaseServico<Tarefa>(Db.DB_PATH);

            CarregarTarefas();
        }

        private async void CarregarTarefas()
        {
            var tarefas = await _tarefaService.TodosAsync();
            TarefasCollectionTable.ItemsSource = tarefas;
        }
    }

}
