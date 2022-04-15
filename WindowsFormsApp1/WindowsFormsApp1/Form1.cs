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
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add(Convert.ToString(r.Next(1, 100)));
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                double x = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                chart1.Series[0].Points.Add(x);
            }
        }
    }
}