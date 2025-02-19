using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SpaceInvaders
{
    public class GameWindow : Window
    {
        public GameWindow()
        {
            InitializeComponent();
            this.FindControl<Button>("GameOverButton").Click += GameOverButton_Click;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void GameOverButton_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            new DeadWindow().Show();
            this.Close();
        }
    }
}