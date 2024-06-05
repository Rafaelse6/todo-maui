using System.Windows.Input;
using ToDoApp.Constants;
using ToDoApp.Models;
using ToDoApp.Services;

namespace ToDoApp.Pages
{
    public partial class MainPage : ContentPage
    {

        DatabaseServico<Tarefa> _tarefaService;

        public ICommand NavigateToDetailCommand { get; private set; }

        public MainPage()
        {
            InitializeComponent();
            _tarefaService = new DatabaseServico<Tarefa>(Db.DB_PATH);

            NavigateToDetailCommand = new Command<Tarefa>(async (tarefa) => await NavigateToDetail(tarefa));
            TarefasCollectionTable.BindingContext = this;

            CarregarTarefas();
        }

        private async Task NavigateToDetail(Tarefa task)
        {
            await Navigation.PushAsync(new TarefasDetalhesPage(task));
        }

        private async void CarregarTarefas()
        {
            var tarefas = await _tarefaService.TodosAsync();
            TarefasCollectionTable.ItemsSource = tarefas;
        }
    }

}
