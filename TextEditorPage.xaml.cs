using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace TextEditor
{
    public partial class TextEditorPage : Page
    {
        public TextEditorPage()
        {
            InitializeComponent();
        }

        private void BoldButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.FontWeight = textBox.FontWeight == FontWeights.Bold ? FontWeights.Normal : FontWeights.Bold;
        }

        private void ItalicButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.FontStyle = textBox.FontStyle == FontStyles.Italic ? FontStyles.Normal : FontStyles.Italic;
        }

        private void UnderlineButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.TextDecorations = textBox.TextDecorations == TextDecorations.Underline ? null : TextDecorations.Underline;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Документ сохранен!", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void FontSizeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                if (int.TryParse((e.AddedItems[0] as ComboBoxItem)?.Content.ToString(), out int newSize))
                {
                    textBox.FontSize = newSize;
                }
            }
        }

    }
}