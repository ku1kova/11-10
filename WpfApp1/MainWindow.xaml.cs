using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Input_Click(object sender, RoutedEventArgs e)
        {
            InputPanel.Visibility = Visibility.Visible;
        }
        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(Number1TextBox.Text, out int num1) ||
                !int.TryParse(Number2TextBox.Text, out int num2) ||
!int.TryParse(Number3TextBox.Text, out int num3))            {
                MessageBox.Show("Введите числа!", "Ошибка"); return;
            }
            string result = "";
            if (SummCheckBox.IsChecked == true)
            {
                int sum = num1 + num2 + num3;
                result += $"Сумма: {sum}\n";
            }
            if (LeastMultipleCheckBox.IsChecked == true)
            {
                int lcm = LeastCommonMultiple(num1, num2);
                result += $"Наименьшее общее кратное: {lcm}\n";
            }
            MessageBox.Show(result, "Результаты");
        }
        private void About_Click(object sender, RoutedEventArgs e)
        { 
            MessageBox.Show("Разработчик: Кулькова Софья", "О программе"); 
        }
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            InputPanel.Visibility = Visibility.Collapsed;
        }
        private int LeastCommonMultiple(int a, int b)
        {
            return (a * b) / GreatestCommonDivisor(a, b);
        }
        private int GreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b; a = temp;
            }
            return a;
        }
    }
}