﻿namespace Calculator
{
    partial class Canculator
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
            this.numeral2 = new System.Windows.Forms.Button();
            this.numeral1 = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.numeral4 = new System.Windows.Forms.Button();
            this.numeral5 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.numeral7 = new System.Windows.Forms.Button();
            this.numeral8 = new System.Windows.Forms.Button();
            this.numeral6 = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.numeral0 = new System.Windows.Forms.Button();
            this.numeral9 = new System.Windows.Forms.Button();
            this.equally = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.numeral3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numeral2
            // 
            this.numeral2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numeral2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeral2.Location = new System.Drawing.Point(86, 77);
            this.numeral2.Name = "numeral2";
            this.numeral2.Size = new System.Drawing.Size(75, 35);
            this.numeral2.TabIndex = 2;
            this.numeral2.Text = "2";
            this.numeral2.UseVisualStyleBackColor = true;
            this.numeral2.Click += new System.EventHandler(this.Numeral2_Click);
            // 
            // numeral1
            // 
            this.numeral1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numeral1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeral1.Location = new System.Drawing.Point(5, 77);
            this.numeral1.Name = "numeral1";
            this.numeral1.Size = new System.Drawing.Size(75, 35);
            this.numeral1.TabIndex = 3;
            this.numeral1.Text = "1";
            this.numeral1.UseVisualStyleBackColor = true;
            this.numeral1.Click += new System.EventHandler(this.Numeral1_Click);
            // 
            // divide
            // 
            this.divide.Enabled = false;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divide.Location = new System.Drawing.Point(248, 77);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 35);
            this.divide.TabIndex = 4;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // numeral4
            // 
            this.numeral4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numeral4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeral4.Location = new System.Drawing.Point(5, 118);
            this.numeral4.Name = "numeral4";
            this.numeral4.Size = new System.Drawing.Size(75, 35);
            this.numeral4.TabIndex = 5;
            this.numeral4.Text = "4";
            this.numeral4.UseVisualStyleBackColor = true;
            this.numeral4.Click += new System.EventHandler(this.Numeral4_Click);
            // 
            // numeral5
            // 
            this.numeral5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numeral5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeral5.Location = new System.Drawing.Point(86, 118);
            this.numeral5.Name = "numeral5";
            this.numeral5.Size = new System.Drawing.Size(75, 35);
            this.numeral5.TabIndex = 6;
            this.numeral5.Text = "5";
            this.numeral5.UseVisualStyleBackColor = true;
            this.numeral5.Click += new System.EventHandler(this.Numeral5_Click);
            // 
            // clear
            // 
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.Location = new System.Drawing.Point(5, 200);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 35);
            this.clear.TabIndex = 7;
            this.clear.Text = "CE";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // numeral7
            // 
            this.numeral7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numeral7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeral7.Location = new System.Drawing.Point(5, 159);
            this.numeral7.Name = "numeral7";
            this.numeral7.Size = new System.Drawing.Size(75, 35);
            this.numeral7.TabIndex = 8;
            this.numeral7.Text = "7";
            this.numeral7.UseVisualStyleBackColor = true;
            this.numeral7.Click += new System.EventHandler(this.Numeral7_Click);
            // 
            // numeral8
            // 
            this.numeral8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numeral8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeral8.Location = new System.Drawing.Point(86, 159);
            this.numeral8.Name = "numeral8";
            this.numeral8.Size = new System.Drawing.Size(75, 35);
            this.numeral8.TabIndex = 9;
            this.numeral8.Text = "8";
            this.numeral8.UseVisualStyleBackColor = true;
            this.numeral8.Click += new System.EventHandler(this.Numeral8_Click);
            // 
            // numeral6
            // 
            this.numeral6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numeral6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeral6.Location = new System.Drawing.Point(167, 118);
            this.numeral6.Name = "numeral6";
            this.numeral6.Size = new System.Drawing.Size(75, 35);
            this.numeral6.TabIndex = 10;
            this.numeral6.Text = "6";
            this.numeral6.UseVisualStyleBackColor = true;
            this.numeral6.Click += new System.EventHandler(this.Numeral6_Click);
            // 
            // multiply
            // 
            this.multiply.Enabled = false;
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiply.Location = new System.Drawing.Point(248, 118);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 35);
            this.multiply.TabIndex = 11;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // numeral0
            // 
            this.numeral0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numeral0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeral0.Location = new System.Drawing.Point(86, 200);
            this.numeral0.Name = "numeral0";
            this.numeral0.Size = new System.Drawing.Size(75, 35);
            this.numeral0.TabIndex = 12;
            this.numeral0.Text = "0";
            this.numeral0.UseVisualStyleBackColor = true;
            this.numeral0.Click += new System.EventHandler(this.Numeral0_Click);
            // 
            // numeral9
            // 
            this.numeral9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numeral9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeral9.Location = new System.Drawing.Point(167, 159);
            this.numeral9.Name = "numeral9";
            this.numeral9.Size = new System.Drawing.Size(75, 35);
            this.numeral9.TabIndex = 13;
            this.numeral9.Text = "9";
            this.numeral9.UseVisualStyleBackColor = true;
            this.numeral9.Click += new System.EventHandler(this.Numeral9_Click);
            // 
            // equally
            // 
            this.equally.Enabled = false;
            this.equally.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equally.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equally.Location = new System.Drawing.Point(167, 200);
            this.equally.Name = "equally";
            this.equally.Size = new System.Drawing.Size(75, 35);
            this.equally.TabIndex = 14;
            this.equally.Text = "=";
            this.equally.UseVisualStyleBackColor = true;
            this.equally.Click += new System.EventHandler(this.Equally_Click);
            // 
            // add
            // 
            this.add.Enabled = false;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(248, 200);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 35);
            this.add.TabIndex = 15;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // minus
            // 
            this.minus.Enabled = false;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.Location = new System.Drawing.Point(248, 159);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 35);
            this.minus.TabIndex = 16;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // numeral3
            // 
            this.numeral3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numeral3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeral3.Location = new System.Drawing.Point(167, 77);
            this.numeral3.Name = "numeral3";
            this.numeral3.Size = new System.Drawing.Size(75, 35);
            this.numeral3.TabIndex = 18;
            this.numeral3.Text = "3";
            this.numeral3.UseVisualStyleBackColor = true;
            this.numeral3.Click += new System.EventHandler(this.Numeral3_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 27);
            this.label1.TabIndex = 19;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Canculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(328, 239);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeral3);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.add);
            this.Controls.Add(this.equally);
            this.Controls.Add(this.numeral9);
            this.Controls.Add(this.numeral0);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.numeral6);
            this.Controls.Add(this.numeral8);
            this.Controls.Add(this.numeral7);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.numeral5);
            this.Controls.Add(this.numeral4);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.numeral1);
            this.Controls.Add(this.numeral2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Canculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button numeral2;
        private System.Windows.Forms.Button numeral1;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button numeral4;
        private System.Windows.Forms.Button numeral5;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button numeral7;
        private System.Windows.Forms.Button numeral8;
        private System.Windows.Forms.Button numeral6;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button numeral0;
        private System.Windows.Forms.Button numeral9;
        private System.Windows.Forms.Button equally;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button numeral3;
        private System.Windows.Forms.Label label1;
    }
}

