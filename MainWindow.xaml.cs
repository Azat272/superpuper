using System.Windows;
using System.Windows.Controls;
using TextEditor;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Task1_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Task1Page();
        }

        private void Task2_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Task2Page();
        }

        private void Task3_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Task3Page();
        }

        private void Task4_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new TextEditorPage();
        }
    }
}
