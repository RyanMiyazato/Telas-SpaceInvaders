using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SpaceInvaders
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.FindControl<Button>("StartButton").Click += StartButton_Click;
            this.FindControl<Button>("ExitButton").Click += ExitButton_Click;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void StartButton_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            new GameWindow().Show();
            this.Close();
        }

        private void ExitButton_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            this.Close();
        }
    }
}