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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
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
      

        public static string GetW(int x)
        {
            string abc = "qwertyuiopasdfghjklzxcvbnm";


            string pass = "";
            Random r = new Random();
            while (pass.Length < x)
            {
                pass += abc[r.Next(abc.Length)];
            }
            return pass;
        }


        public static string GetC(int c)
        {
            string abc = "!@#$%^&*()";


            string pass = "";
            Random r = new Random();
            while (pass.Length < c)
            {
                pass += abc[r.Next(abc.Length)];
            }
            return pass;
        }

        public static string GetN(int bw)
        {
            string abc = "1234567890";

            string pass = "";
            Random r = new Random();
            while (pass.Length < bw)
            {
                pass += abc[r.Next(abc.Length)];
            }
            return pass;
        }

        static string Shuffle(string s)
        {
            Random rand = new Random();
            char b;
            char[] chars = s.ToCharArray();
            for (int i = chars.Length - 1; i > 0; i--)
            {

                int j = rand.Next(i);
                b = chars[j];
                chars[j] = chars[i];
                chars[i] = b;
            }

            return new string(chars);
        }

       
            
         

            private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                string word = GetW(Convert.ToInt32(textBox4.Text));
                string number = GetN(Convert.ToInt32(textBox2.Text));
                string chars = GetC(Convert.ToInt32(textBox3.Text));


                string pass = word + number + chars;

                textBox5.Text = Shuffle(pass);

                DoubleAnimation Anim = new DoubleAnimation();

                Anim.From = 110; Anim.To = 100;

                Anim.Duration = TimeSpan.FromSeconds(0.5);

                button1.BeginAnimation(Button.WidthProperty, Anim);
            }
            else
            {
                MessageBox.Show( "Не все значения введены");
               
            }
        }

        private void textBox4_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }
    }
}
