using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Pen myPen = new Pen(Color.Black, 2);
            Rectangle[] myRectsArray=
            {
                 new Rectangle(10, 10, 200, 200),
                 new Rectangle(20, 20, 180, 180),
                 new Rectangle(30, 30, 160, 160)};
         
            Graphics g = e.Graphics; 
            g.DrawRectangles(myPen, myRectsArray);

        }
    }
}
