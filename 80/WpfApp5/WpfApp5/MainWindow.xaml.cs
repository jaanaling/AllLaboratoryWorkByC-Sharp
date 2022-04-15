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
        string[] str = new string[4000];
        string[] str2 = new string[4000];
        int i = 0;
        int t = 0;
        public MainWindow()
        {
            InitializeComponent();
    
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            str[i] = textBox1.Text;

            listBox1.Items.Add(str[i]);
            i++;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            for (int g = 0; g < i + 1; g++)
            {
                if (textBox2.Text == str[g])
                {
                    str2[t] = textBox2.Text;
                    listBox2.Items.Add(str2[t]);
                    t++;
                    break;
                }
                if (g == i)
                {
                    MessageBox.Show("Не существует такого сотрудника");
                }
            }
        }
    }
}
