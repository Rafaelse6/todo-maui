using System.Windows.Input;
using ToDoApp.Constants;
using ToDoApp.Models;
using ToDoApp.Services;

namespace ToDoApp
{
    public partial class MainPage : ContentPage
    {

        DatabaseServico<Tarefa> _tarefaService;

        public ICommand AlertCommand { get; set; }

        public MainPage()
        {
            InitializeComponent();
            _tarefaService = new DatabaseServico<Tarefa>(Db.DB_PATH);

            AlertCommand = new Command<Tarefa>(ExecuteAlertCommand);
            TarefasCollectionTable.BindingContext = this;

            CarregarTarefas();
        }

        private void ExecuteAlertCommand(Tarefa tarefa)
        {
            DisplayAlert("Alerta", $"Tarefa: {tarefa.Titulo}", "OK");
        }

        private async void CarregarTarefas()
        {
            var tarefas = await _tarefaService.TodosAsync();
            TarefasCollectionTable.ItemsSource = tarefas;
        }
    }

}
