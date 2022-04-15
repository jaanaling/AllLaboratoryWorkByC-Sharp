
namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вычитаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.умножениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.делениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычитаниеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.ыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ыToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 102);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сумма";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 102);
            this.button2.TabIndex = 1;
            this.button2.Text = "Вычитание";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(236, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 102);
            this.button3.TabIndex = 2;
            this.button3.Text = "Умножение";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(236, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Результат";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(236, 305);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 102);
            this.button5.TabIndex = 2;
            this.button5.Text = "Деление";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ыToolStripMenuItem,
            this.ыToolStripMenuItem1,
            this.ыToolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(951, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вычитаниеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(951, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вычитаниеToolStripMenuItem
            // 
            this.вычитаниеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.умножениеToolStripMenuItem,
            this.делениеToolStripMenuItem,
            this.сложениеToolStripMenuItem,
            this.вычитаниеToolStripMenuItem1});
            this.вычитаниеToolStripMenuItem.Name = "вычитаниеToolStripMenuItem";
            this.вычитаниеToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.вычитаниеToolStripMenuItem.Text = "Инстументы";
            this.вычитаниеToolStripMenuItem.Click += new System.EventHandler(this.вычитаниеToolStripMenuItem_Click);
            // 
            // умножениеToolStripMenuItem
            // 
            this.умножениеToolStripMenuItem.Name = "умножениеToolStripMenuItem";
            this.умножениеToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.умножениеToolStripMenuItem.Text = "Умножение";
            this.умножениеToolStripMenuItem.Click += new System.EventHandler(this.умножениеToolStripMenuItem_Click);
            // 
            // делениеToolStripMenuItem
            // 
            this.делениеToolStripMenuItem.Name = "делениеToolStripMenuItem";
            this.делениеToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.делениеToolStripMenuItem.Text = "Деление";
            this.делениеToolStripMenuItem.Click += new System.EventHandler(this.делениеToolStripMenuItem_Click);
            // 
            // сложениеToolStripMenuItem
            // 
            this.сложениеToolStripMenuItem.Name = "сложениеToolStripMenuItem";
            this.сложениеToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.сложениеToolStripMenuItem.Text = "Сложение";
            this.сложениеToolStripMenuItem.Click += new System.EventHandler(this.сложениеToolStripMenuItem_Click);
            // 
            // вычитаниеToolStripMenuItem1
            // 
            this.вычитаниеToolStripMenuItem1.Name = "вычитаниеToolStripMenuItem1";
            this.вычитаниеToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.вычитаниеToolStripMenuItem1.Text = "Вычитание";
            this.вычитаниеToolStripMenuItem1.Click += new System.EventHandler(this.вычитаниеToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(951, 591);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(587, 51);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(294, 213);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(587, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(294, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Значения";
            this.Column1.Name = "Column1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(602, 426);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(258, 74);
            this.button4.TabIndex = 14;
            this.button4.Text = "Построить график";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // ыToolStripMenuItem
            // 
            this.ыToolStripMenuItem.Name = "ыToolStripMenuItem";
            this.ыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ыToolStripMenuItem.Text = "ы";
            // 
            // ыToolStripMenuItem1
            // 
            this.ыToolStripMenuItem1.Name = "ыToolStripMenuItem1";
            this.ыToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ыToolStripMenuItem1.Text = "ы";
            // 
            // ыToolStripMenuItem2
            // 
            this.ыToolStripMenuItem2.Name = "ыToolStripMenuItem2";
            this.ыToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.ыToolStripMenuItem2.Text = "ы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 591);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem вычитаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem умножениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem делениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сложениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычитаниеToolStripMenuItem1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem ыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ыToolStripMenuItem2;
    }
}

