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

namespace _2задание
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isDrawing = false;
        private SolidColorBrush brushColor = Brushes.Black;
        private int brushSize = 5;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ColorComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                brushColor = (SolidColorBrush)new BrushConverter().ConvertFromString(selectedItem.Tag.ToString());
                DrawingCanvas.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(selectedItem.Tag.ToString());
            }
        }

        private void SizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            brushSize = (int)e.NewValue;
            DrawingCanvas.DefaultDrawingAttributes.Height = brushSize;

        }

        private void MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (DrawMode.IsChecked == true)
            {
                isDrawing = true;
                DrawingCanvas.Strokes.Clear();
            }
        }

            private void MouseMove(object sender, MouseEventArgs e)
            {

            }

            private void MouseUp(object sender, MouseButtonEventArgs e)
            {

            }
        }
    }
