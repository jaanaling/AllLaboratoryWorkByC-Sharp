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
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "ClipRectangle", e.ClipRectangle);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Graphics", e.Graphics);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "Paint Event");
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
