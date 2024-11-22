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

namespace задание1
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

        private void CloseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void AboutDeveloperMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Кулькова Софья\nКонтакт: sofya.kulkova.06@gmail.com", "О разработчике", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ChangeColor_Click(object sender, RoutedEventArgs e)
        {
            gr1.Background = Brushes.LightGreen;
        }

    }
}
