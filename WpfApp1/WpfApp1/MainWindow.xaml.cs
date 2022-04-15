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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int a = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
               
                label3.Content = Convert.ToString(a + b);
                label3.Foreground = Brushes.Black;
            }
            else
            {
                label3.Content  = "Не все значения введены";
                label3.Foreground = Brushes.Red;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int a = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);

                label3.Content = Convert.ToString(a - b);
                label3.Foreground = Brushes.Black;
            }
            else
            {
                label3.Content = "Не все значения введены";
                label3.Foreground = Brushes.Red;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int a = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);

                label3.Content = Convert.ToString(a * b);
                label3.Foreground = Brushes.Black;
            }
            else
            {
                label3.Content = "Не все значения введены";
                label3.Foreground = Brushes.Red;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int a = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);

                label3.Content = Convert.ToString(a / b);
                label3.Foreground = Brushes.Black;
            }
            else
            {
                label3.Content = "Не все значения введены";
                label3.Foreground = Brushes.Red;
            }
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }

        private void TextBox_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
