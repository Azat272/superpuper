using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1
{
    public partial class Task3Page : Page
    {
        public Task3Page()
        {
            InitializeComponent();
        }


        private void StyledButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кнопка нажата!", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
