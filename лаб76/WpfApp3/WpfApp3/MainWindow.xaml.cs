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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private string ff;
        public MainWindow(/*string dd*/)
        {
            InitializeComponent();
            
            //ff = dd;
        }

   

      

        private void miExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
  int a = 0;
        private void miInput_Click(object sender, RoutedEventArgs e)
        {
            //Window1 window1 = new Window1();
            //window1.DataContext = this;
            //window1.Show()
          
            if (a == 0) {
                textBox1.Visibility = Visibility;
                textBox12.Visibility = Visibility;
                textBox2.Visibility = Visibility;
                textBox22.Visibility = Visibility;
                textBox3.Visibility = Visibility;
                textBox32.Visibility = Visibility;
                label1.Visibility = Visibility;
                label2.Visibility = Visibility;
                label3.Visibility = Visibility;
                checkBox1.Visibility = Visibility;
                checkBox2.Visibility = Visibility;

                pBox.Visibility = Visibility.Hidden;
                a = 1;
            }
            else
            {
                textBox1.Visibility = Visibility.Hidden;
                textBox12.Visibility = Visibility.Hidden;
                textBox2.Visibility = Visibility.Hidden;
                textBox22.Visibility = Visibility.Hidden;
                textBox3.Visibility = Visibility.Hidden;
                textBox32.Visibility = Visibility.Hidden;
                label1.Visibility = Visibility.Hidden;
                label2.Visibility = Visibility.Hidden;
                label3.Visibility = Visibility.Hidden;
                checkBox1.Visibility = Visibility.Hidden;
                checkBox2.Visibility = Visibility.Hidden;

                pBox.Visibility = Visibility;
                a = 0;
            }
        }

        private void miWork_Click(object sender, RoutedEventArgs e)
        {
            //Window1 window1 = new Window1();
            //window1.DataContext = this;
            double vol;
            double mass;
            
            double r = Convert.ToDouble(textBox1.Text + "," + textBox12.Text);
            double h = Convert.ToDouble(textBox2.Text + "," + textBox22.Text);
            double d = Convert.ToDouble(textBox3.Text + "," + textBox32.Text);

            vol = (1d / 3d) * Math.PI * Math.Pow(r, 2) * h;
            mass = vol * d;

            if (checkBox1.IsChecked == (bool?)true && checkBox2.IsChecked == (bool?)true)
            {
                MessageBox.Show("Volume = "+ vol+" Mass = "+mass);
            }
            else if (checkBox1.IsChecked == true && checkBox2.IsChecked == false)
            {
                MessageBox.Show("Volume = " + vol);
            }
            else if (checkBox1.IsChecked == false && checkBox2.IsChecked == true)
            {
                MessageBox.Show("Mass = " + mass);
            }
            else
            {
                MessageBox.Show(Convert.ToString("Dont choose!"));
            }
        }





        private void textBox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void textBox12_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void textBox22_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void textBox3_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void textBox32_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }
    }
}
