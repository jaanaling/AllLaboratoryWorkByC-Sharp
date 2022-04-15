using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        string[] str = new string[4000] ;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            str[i] = textBox1.Text;
            
            listBox1.Items.Add(str[i]);
            i++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
