using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

using AvaloniaHelloViewModels.Models;

namespace passAlert
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new HelloViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}