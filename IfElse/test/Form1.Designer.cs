﻿namespace test
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kanit", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(287, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "คำนวณเกรด";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kanit", 25.8F);
            this.label2.Location = new System.Drawing.Point(123, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 68);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อ-สกุล";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kanit", 25.8F);
            this.label3.Location = new System.Drawing.Point(123, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 68);
            this.label3.TabIndex = 2;
            this.label3.Text = "คะแนน";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kanit", 25.8F);
            this.label4.Location = new System.Drawing.Point(123, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 68);
            this.label4.TabIndex = 3;
            this.label4.Text = "เกรด";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Kanit", 25.8F);
            this.textBox1.Location = new System.Drawing.Point(325, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 72);
            this.textBox1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kanit", 25.8F);
            this.label5.Location = new System.Drawing.Point(366, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 68);
            this.label5.TabIndex = 5;
            this.label5.Text = "00";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Kanit", 25.8F);
            this.textBox2.Location = new System.Drawing.Point(325, 202);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 72);
            this.textBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Kanit", 25.8F);
            this.button1.Location = new System.Drawing.Point(584, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 78);
            this.button1.TabIndex = 7;
            this.button1.Text = "ตรวจสอบกรด";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 604);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}

