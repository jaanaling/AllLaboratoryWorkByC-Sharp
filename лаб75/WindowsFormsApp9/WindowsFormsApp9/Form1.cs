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
            настройкиToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.S;
            выходToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //загружаем фоновый цвет
            this.BackColor = Properties.Settings.Default.BackgroundColor;
            //загружаем шрифт
            this.Font = Properties.Settings.Default.FormFont;
            //загружаем размеры окна
            this.Width = Properties.Settings.Default.FormWidth;
            this.Height = Properties.Settings.Default.FormHeight;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //запись настроек
            Properties.Settings.Default.BackgroundColor = this.BackColor;
            Properties.Settings.Default.FormWidth = this.Width;
            Properties.Settings.Default.FormHeight = this.Height;
            Properties.Settings.Default.FormFont = this.Font;
            //сохранение настроек
            Properties.Settings.Default.Save();

        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Объявляем екземпляр формы
            Form2 frm = new Form2();
            //если на форме настроек была нажата кнопка ОК, а не Отмена выполняем следующий код
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //присваиваем значение фонового цвета
                this.BackColor = Properties.Settings.Default.BackgroundColor = frm.GetColor;
                //присваиваем значение шрифта
                this.Font = Properties.Settings.Default.FormFont = frm.GetFormFont;
                //сохраняем настройки
                Properties.Settings.Default.Save();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
