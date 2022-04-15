using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кнопки
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

