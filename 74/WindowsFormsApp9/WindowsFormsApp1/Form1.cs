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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Для каждого элемента управления
            foreach (Control c in Controls)
            {
                // задаем контекстное меню.
                c.ContextMenuStrip = contextMenuStrip1;
                // Указываем для каждого элемента
                // обработчик для правой кнопки мыши.
                c.MouseDown += new MouseEventHandler(this.ShowPopupMenu);
            }
        }
        private void ShowPopupMenu(object sender,System.Windows.Forms.MouseEventArgs e)
        {
            // Если нажата правая кнопка мыши.
            if (e.Button == MouseButtons.Right)
            {
                Control c = (Control)sender;
                // Если контекстное меню у элемента существует,
                if (c.ContextMenu != null)
                {
                    // то показываем его.
                    c.ContextMenu.Show(c, new Point(e.X, e.Y));
                }
            }
        }
    }
}
