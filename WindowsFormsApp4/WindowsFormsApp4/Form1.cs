using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.ContextMenuStrip = contextMenuStrip1;
            contextMenuStrip1.Items.Add(menuStrip1.Items[1].ToString());
            умножениеToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.M;
            вычитаниеToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.S;
            делениеToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            сложениеToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "")
            {
                int a = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
                label1.Text = "+";
                label3.Text = Convert.ToString(a + b);

                label3.ForeColor = Color.Black;
                dataGridView1.Rows.Add(label3.Text);
            }
            else
            {
                label3.Text = "Не все значения введены";
                label3.ForeColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        { }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "")
            {
                int a = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
                label1.Text = "-";
                label3.Text = Convert.ToString(a - b);

                label3.ForeColor = Color.Black;
                dataGridView1.Rows.Add(label3.Text);
            }
            else
            {
                label3.Text = "Не все значения введены";
                label3.ForeColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "")
            {
                int a = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
                label1.Text = "*";
                label3.Text = Convert.ToString(a * b);

                label3.ForeColor = Color.Black;
                dataGridView1.Rows.Add(label3.Text);
            }
            else
            {
                label3.Text = "Не все значения введены";
                label3.ForeColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox1.Text != "")
            {
                int a = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
                label1.Text = "/";
                label3.Text = Convert.ToString(a / b);

                label3.ForeColor = Color.Black;
                dataGridView1.Rows.Add(label3.Text);
            }
            else
            {
                label3.Text = "Не все значения введены";
                label3.ForeColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void очиститьОтветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = null;
            label1.Text = null;
        }

        private void удалитьПеровеЗначениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void удалитьВтороеЗначениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void удалитьОбаЗначенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void умножениеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox1.Text != "")
            {
                int a = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
                label1.Text = "*";
                label3.Text = Convert.ToString(a * b);

                label3.ForeColor = Color.Black;
                dataGridView1.Rows.Add(label3.Text);
            }
            else
            {
                label3.Text = "Не все значения введены";
                label3.ForeColor = Color.Red;
            }
        }

        private void делениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "")
            {
                int a = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
                label1.Text = "/";
                label3.Text = Convert.ToString(a / b);

                label3.ForeColor = Color.Black;
                dataGridView1.Rows.Add(label3.Text);
            }
            else
            {
                label3.Text = "Не все значения введены";
                label3.ForeColor = Color.Red;
            }
        }

        private void сложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "")
            {
                int a = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
                label1.Text = "+";
                label3.Text = Convert.ToString(a + b);

                label3.ForeColor = Color.Black;
                dataGridView1.Rows.Add(label3.Text);
            }
            else
            {
                label3.Text = "Не все значения введены";
                label3.ForeColor = Color.Red;
            }
        }

        private void вычитаниеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "")
            {
                int a = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
                label1.Text = "-";
                label3.Text = Convert.ToString(a - b);

                label3.ForeColor = Color.Black;
                dataGridView1.Rows.Add(label3.Text);
            }
            else
            {
                label3.Text = "Не все значения введены";
                label3.ForeColor = Color.Red;
            }
        }

        private void вычитаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "")
            {
                int a = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
                label1.Text = "-";
                label3.Text = Convert.ToString(a - b);

                label3.ForeColor = Color.Black;
                dataGridView1.Rows.Add(label3.Text);
            }
            else
            {
                label3.Text = "Не все значения введены";
                label3.ForeColor = Color.Red;
            }
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                double x = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
               
                chart1.Series[0].Points.Add(x);
                //chart1.Series[0].Points.AddXY(x, y);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
