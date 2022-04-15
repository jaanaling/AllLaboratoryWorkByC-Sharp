using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form2 : Form
    {
        Font font;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Properties.Settings.Default.BackgroundColor;
            font = Properties.Settings.Default.FormFont;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        public Color GetColor
        {
            get { return pictureBox1.BackColor; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //загружаем текущие настройки шрифта
            fontDialog1.Font = Properties.Settings.Default.FormFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                font = fontDialog1.Font;
            }
        }

        public Font GetFormFont
        {
            get { return font; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
