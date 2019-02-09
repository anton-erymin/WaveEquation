namespace WaveEquation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumx = new System.Windows.Forms.TextBox();
            this.txtNumt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtT0 = new System.Windows.Forms.TextBox();
            this.txtTn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtA2 = new System.Windows.Forms.TextBox();
            this.txtSigma = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPause = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Разбиение по пространству";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Разбиение по времени";
            // 
            // txtNumx
            // 
            this.txtNumx.Location = new System.Drawing.Point(167, 6);
            this.txtNumx.Name = "txtNumx";
            this.txtNumx.Size = new System.Drawing.Size(57, 20);
            this.txtNumx.TabIndex = 3;
            this.txtNumx.Text = "100";
            // 
            // txtNumt
            // 
            this.txtNumt.Location = new System.Drawing.Point(167, 28);
            this.txtNumt.Name = "txtNumt";
            this.txtNumt.Size = new System.Drawing.Size(57, 20);
            this.txtNumt.TabIndex = 4;
            this.txtNumt.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Моделировать от";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "до";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "с";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "с";
            // 
            // txtT0
            // 
            this.txtT0.Location = new System.Drawing.Point(342, 6);
            this.txtT0.Name = "txtT0";
            this.txtT0.Size = new System.Drawing.Size(42, 20);
            this.txtT0.TabIndex = 9;
            this.txtT0.Text = "0";
            // 
            // txtTn
            // 
            this.txtTn.Location = new System.Drawing.Point(443, 6);
            this.txtTn.Name = "txtTn";
            this.txtTn.Size = new System.Drawing.Size(42, 20);
            this.txtTn.TabIndex = 10;
            this.txtTn.Text = "15";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Коэффициент а";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Вес сигма";
            // 
            // txtA2
            // 
            this.txtA2.Location = new System.Drawing.Point(167, 51);
            this.txtA2.Name = "txtA2";
            this.txtA2.Size = new System.Drawing.Size(57, 20);
            this.txtA2.TabIndex = 13;
            this.txtA2.Text = "6";
            // 
            // txtSigma
            // 
            this.txtSigma.Location = new System.Drawing.Point(342, 28);
            this.txtSigma.Name = "txtSigma";
            this.txtSigma.Size = new System.Drawing.Size(42, 20);
            this.txtSigma.TabIndex = 14;
            this.txtSigma.Text = "0.5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Пауза в мс";
            // 
            // txtPause
            // 
            this.txtPause.Location = new System.Drawing.Point(342, 51);
            this.txtPause.Name = "txtPause";
            this.txtPause.Size = new System.Drawing.Size(42, 20);
            this.txtPause.TabIndex = 16;
            this.txtPause.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 621);
            this.Controls.Add(this.txtPause);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSigma);
            this.Controls.Add(this.txtA2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTn);
            this.Controls.Add(this.txtT0);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumt);
            this.Controls.Add(this.txtNumx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "nfrjt ;t";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumx;
        private System.Windows.Forms.TextBox txtNumt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtT0;
        private System.Windows.Forms.TextBox txtTn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtA2;
        private System.Windows.Forms.TextBox txtSigma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPause;
    }
}

