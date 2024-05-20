using ToDoApp.Constants;
using ToDoApp.Models;
using ToDoApp.Services;

namespace ToDoApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

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
            TarefasCollectionView.ItemsSource = tarefas;
            TarefasCollectionTable.ItemsSource = tarefas;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Cliquei aqui {count} vezes";
            else
                CounterBtn.Text = $"Cliquei aqui {count} vezes";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
