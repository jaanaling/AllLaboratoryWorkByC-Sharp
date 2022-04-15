using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g =e.Graphics;
            Rectangle rect = new Rectangle(50, 30, 100, 100);
            LinearGradientBrush lBrush = new LinearGradientBrush(rect, Color.Red, Color.Yellow,
         LinearGradientMode.BackwardDiagonal);
            g.FillRectangle(lBrush, rect);
        }
      


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            OnPaint(e);
        }
    }
}
