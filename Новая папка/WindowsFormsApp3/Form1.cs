using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
       public string[] employees=new string[20];
       public string[] request = new string[20];
       int i = 0;
       int l = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employees[i]=textBox1.Text;
            listBox1.Items.Add(employees[i]);
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (employees.Contains(textBox2.Text))
            {
                request[l] = textBox1.Text;
                listBox2.Items.Add(request[l]);
                l++;
            }
            else
            {
                MessageBox.Show(textBox2.Text + " нет в первом списке");
            }
        }
    }
}
