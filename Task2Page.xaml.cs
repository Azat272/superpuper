using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1
{
    public partial class Task2Page : Page
    {
        private bool isClicked = false;

        public Task2Page()
        {
            InitializeComponent();
        }

        private void StyledButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isClicked)
            {
                StyledButton.Background = Brushes.Purple;
                StyledButton.Content = "Я изменился!";
                isClicked = true;
            }
            else
            {
                StyledButton.Background = Brushes.LightBlue;
                StyledButton.Content = "Нажми меня";
                isClicked = false;
            }
        }
        private void TextBlock_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock clickedText = sender as TextBlock;
            if (clickedText != null)
            {
                clickedText.Foreground = clickedText.Foreground == Brushes.Red ? Brushes.Black : Brushes.Red;
            }
        }
    }
}
