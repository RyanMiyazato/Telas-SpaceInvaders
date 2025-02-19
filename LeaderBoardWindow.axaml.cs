using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SpaceInvaders
{
    public class LeaderBoardWindow : Window
    {
        public LeaderBoardWindow()
        {
            InitializeComponent();
            this.FindControl<Button>("BackButton").Click += BackButton_Click;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void BackButton_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }
    }
}