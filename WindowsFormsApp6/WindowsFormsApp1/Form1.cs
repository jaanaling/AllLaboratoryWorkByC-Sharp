using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string[] str = new string[4000];
        string[] str2 = new string[4000];
        int i = 0;
        int t = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            str[i] = textBox1.Text;

            listBox1.Items.Add(str[i]);
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int g =0; g<i+1; g++)
            {
                if (textBox2.Text== str[g])
                {
                    str2[t] = textBox2.Text;
                    listBox2.Items.Add(str2[t]);
                    t++;
                    break;
                }
                if(g==i)
                {
                    MessageBox.Show("Не существует такого сотрудника");
                }
            }
        }
    }
}
