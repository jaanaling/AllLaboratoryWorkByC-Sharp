
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWork = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.txbB = new System.Windows.Forms.TextBox();
            this.txbA = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(68, 104);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(75, 23);
            this.btnWork.TabIndex = 0;
            this.btnWork.Text = "work";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(187, 72);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "sum";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txbB
            // 
            this.txbB.Location = new System.Drawing.Point(270, 31);
            this.txbB.Name = "txbB";
            this.txbB.Size = new System.Drawing.Size(100, 23);
            this.txbB.TabIndex = 2;
            // 
            // txbA
            // 
            this.txbA.Location = new System.Drawing.Point(68, 31);
            this.txbA.Name = "txbA";
            this.txbA.Size = new System.Drawing.Size(100, 23);
            this.txbA.TabIndex = 3;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(108, 13);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(13, 15);
            this.lblA.TabIndex = 4;
            this.lblA.Text = "a";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(295, 13);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(14, 15);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "b";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(210, 38);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(38, 15);
            this.lblC.TabIndex = 6;
            this.lblC.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 161);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txbA);
            this.Controls.Add(this.txbB);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnWork);
            this.Name = "Form1";
            this.Text = "Асинхронный запуск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txbB;
        private System.Windows.Forms.TextBox txbA;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
    }
}

