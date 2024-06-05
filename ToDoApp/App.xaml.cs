namespace ToDoApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell(); // it changes the whole page
            //MainPage = new NavigationPage(new AppShell()); // it changes only one menu frame
        }
    }
}
