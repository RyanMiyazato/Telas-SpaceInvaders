using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SpaceInvaders
{
    public class DeadWindow : Window
    {
        public DeadWindow()
        {
            InitializeComponent();
            this.FindControl<Button>("RestartButton").Click += RestartButton_Click;
            this.FindControl<Button>("LeaderBoardButton").Click += LeaderBoardButton_Click;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void RestartButton_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            new GameWindow().Show();
            this.Close();
        }

        private void LeaderBoardButton_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            new LeaderBoardWindow().Show();
        }
    }
}