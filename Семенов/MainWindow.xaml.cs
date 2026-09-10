using System.Windows;

namespace Семенов
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnShowClick(object sender, RoutedEventArgs e)
        {
            string input = InputBox.Text;
            ResultLabel.Text = string.IsNullOrEmpty(input)
                ? "Вы ничего не ввели."
                : "Вы ввели: " + input;
        }
    }
}
