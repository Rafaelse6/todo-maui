using ToDoApp.Models;

namespace ToDoApp.Pages
{
    public partial class TarefasDetalhesPage : ContentPage
    {
        public Tarefa Tarefa { get; set; }
        public TarefasDetalhesPage(Tarefa tarefa)
        {
            InitializeComponent();
            Tarefa = tarefa;
            BindingContext = this;
        }

        private async void VoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
