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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создание контекстного меню.
            ContextMenu cm = new ContextMenu();
            // Слияние меню.
            cm.Handle(menuStrip1.Items[1]);
            // Подсоединение контекстного меню к главному окну.
            ContextMenu = cm;
        }
    }
}
