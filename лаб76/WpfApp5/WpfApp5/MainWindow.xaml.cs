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

namespace WpfApp5
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
        int a = 0;
        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
          
           
           
        }

        private void miSize_Click(object sender, RoutedEventArgs e)
        {
            if (a == 0)
            {
                textBox1.Visibility = Visibility;
                textBox2.Visibility = Visibility;
                label1.Visibility = Visibility;
                label2.Visibility = Visibility;
                checkBox1.Visibility = Visibility;
                checkBox2.Visibility = Visibility;
                checkBox3.Visibility = Visibility;
                pBox.Visibility = Visibility.Hidden;
                rectan.Visibility = Visibility;
                a = 1;
            }
            else
            {
                textBox1.Visibility = Visibility.Hidden;      
                textBox2.Visibility = Visibility.Hidden;
                label1.Visibility = Visibility.Hidden;
                label2.Visibility = Visibility.Hidden;
                checkBox1.Visibility = Visibility.Hidden;
                checkBox2.Visibility = Visibility.Hidden;
                checkBox3.Visibility = Visibility.Hidden;
                pBox.Visibility = Visibility;
                rectan.Visibility = Visibility.Hidden;
                a = 0;
            }
        }

        private void textBox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void textBox2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void miQuit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void miPaint_Click(object sender, RoutedEventArgs e)
        {
            rectan.Width = Convert.ToDouble(textBox1.Text);
            rectan.Height = Convert.ToDouble(textBox2.Text);

            if (checkBox1.IsChecked == true && checkBox2.IsChecked == true && checkBox3.IsChecked == true)
            {
                rectan.Fill = Brushes.White;
            }
            else if (checkBox1.IsChecked == true && checkBox2.IsChecked == true && checkBox3.IsChecked ==false)
            {
                rectan.Fill = Brushes.Yellow;
            }
            else if (checkBox1.IsChecked == true && checkBox2.IsChecked == false && checkBox3.IsChecked == false)
            {
                rectan.Fill = Brushes.Red;
            }
            else if (checkBox1.IsChecked == false && checkBox2.IsChecked == true && checkBox3.IsChecked == false)
            {
                rectan.Fill = Brushes.Green;
            }
            else if (checkBox1.IsChecked == false && checkBox2.IsChecked == false && checkBox3.IsChecked == true)
            {
                rectan.Fill = Brushes.Blue;
            }
            else if (checkBox1.IsChecked == false && checkBox2.IsChecked == true && checkBox3.IsChecked == true)
            {
                rectan.Fill = Brushes.Turquoise;
            }
            else if (checkBox1.IsChecked == true && checkBox2.IsChecked ==false  && checkBox3.IsChecked == true)
            {
                rectan.Fill = Brushes.Pink;
            }
            else
            {
                rectan.Fill = Brushes.Black;
            }

        }

        private void miColor_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
