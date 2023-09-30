using Lib_9;
using System.Windows;
using System.Collections.Generic;

namespace Practice1
{
    /// <summary>
    /// Логика взаимодействия MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButtonClick(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(NTextBox.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Некорректное значение");
                return;
            }

            if (n >= 1e6 &&
                MessageBox.Show("Расчёт может занять много времени, продолжить?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                return;

            List<int> numbers = new List<int>();

            ResultTextBox.Text = Dream.GetSumOfNIntegers(n, numbers).ToString();
            NumbersTextBox.Text = string.Join(", ", numbers);
        }

        private void AboutButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "ИСП-31 Рязанцев Дмитрий Александрович\n" +
                "Задание: Сформировать n целых чисел в диапазоне 2-14. Найти сумму чисел < 8. Результат вывести на экран",
                "О программе",
                MessageBoxButton.OK,
                MessageBoxImage.Information
                );
        }

        private void ExitButtonClick(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                Close();
        }

        private void NTextBoxChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            NumbersTextBox.Text = string.Empty;
            ResultTextBox.Text = string.Empty;
        }
    }
}
