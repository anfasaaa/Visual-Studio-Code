namespace Simulasi_Lengan_2_DOF
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtL1 = new System.Windows.Forms.TextBox();
            this.txtL2 = new System.Windows.Forms.TextBox();
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 320);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Panjang Lengan 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Panjang Lengan 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sudut Lengan 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sudut Lengan 2";
            // 
            // txtL1
            // 
            this.txtL1.Location = new System.Drawing.Point(668, 53);
            this.txtL1.Name = "txtL1";
            this.txtL1.Size = new System.Drawing.Size(100, 20);
            this.txtL1.TabIndex = 5;
            // 
            // txtL2
            // 
            this.txtL2.Location = new System.Drawing.Point(668, 90);
            this.txtL2.Name = "txtL2";
            this.txtL2.Size = new System.Drawing.Size(100, 20);
            this.txtL2.TabIndex = 6;
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(668, 126);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(100, 20);
            this.txtS1.TabIndex = 7;
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(668, 165);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(100, 20);
            this.txtS2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Proses";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(755, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 352);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtS2);
            this.Controls.Add(this.txtS1);
            this.Controls.Add(this.txtL2);
            this.Controls.Add(this.txtL1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtL1;
        private System.Windows.Forms.TextBox txtL2;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

