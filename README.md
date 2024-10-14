<Window x:Class="задание1.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:задание1"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
     <Grid x:Name="gr1">

        <Menu Background="White" BorderBrush="Navy" BorderThickness="1" Margin="0,0,27,384">
            <MenuItem Header="_Файл">
                <MenuItem Name="mi_open" Header="_Oткрыть" Click="MenuItem_Click" />

                <MenuItem Header="_Соxранить" />
                <Separator />
                <MenuItem Header="_Зaкpыть" />


            </MenuItem>
            <MenuItem Header="_О пpoгpaммe" />
        </Menu>

        <ToolBar Margin="520,0,0,359">
            <Button Click="AboutDeveloperMenuItem_Click"
>
                <Image Source="C:\Users\student\Desktop\Решение КСЗ\11r\Image\1466617.png"></Image>
            </Button>
            <Separator/>
            <Button Click="CloseMenuItem_Click">
                <Image Source="C:\Users\student\Desktop\Решение КСЗ\11r\Image\9136168.png"></Image>
            </Button>
            <Button Height="50" Margin="0,0,0,5" Width="55" Click="ChangeColor_Click">
                <Image Source="C:\Users\student\Desktop\Решение КСЗ\11r\Image\Без названия.png"></Image>
            </Button>

        </ToolBar>

        <StatusBar DockPanel.Dock="Bottom" Margin="0,390,0,0">
            <TextBlock Text="Сохранение документа ..." />
            <StatusBarItem HorizontalAlignment="Right" >
                <TextBlock Text="Подключение к БД: ОК" />
            </StatusBarItem>
        </StatusBar>


    </Grid>
</Window>










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

