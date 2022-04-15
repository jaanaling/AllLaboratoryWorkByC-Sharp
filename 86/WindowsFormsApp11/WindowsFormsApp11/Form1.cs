using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThreeDim
{
    public partial class Form1 : Form
    {
        int alpha, beta, gamma;
        Matrix3D A, B, C, D, R;
        Cube3D Q;
        int scale = 50;

        public Form1()
        {
            InitializeComponent();
            A = new Matrix3D();
            B = new Matrix3D();
            C = new Matrix3D();
            D = new Matrix3D();
            R = new Matrix3D();
            Q = new Cube3D();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            alpha = trackBar1.Value;
            textBox1.Text = alpha.ToString();
            A.Rotate(0, alpha);
            Calculate();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            beta = trackBar2.Value;
            textBox2.Text = beta.ToString();
            B.Rotate(1, beta);
            Calculate();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            gamma = trackBar3.Value;
            textBox3.Text = gamma.ToString();
            C.Rotate(2, gamma);
            Calculate();
        }

        private void Calculate()
        {
            D.Mult(B, C);
            R.Mult(A, D);
            Q.Rotate(R);
            panel1.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TranslateTransform(panel1.Width / 2, panel1.Height / 2);
            Q.Paint(g, scale);
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            scale = trackBar4.Value;
            panel1.Invalidate();
        }
    }
}

