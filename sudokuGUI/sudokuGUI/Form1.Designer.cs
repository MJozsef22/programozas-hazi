﻿namespace sudokuGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exit_bt = new System.Windows.Forms.Button();
            this.ellenorzes_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.minus_bt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.plus_bt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.hossz_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit_bt
            // 
            this.exit_bt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_bt.ForeColor = System.Drawing.Color.Crimson;
            this.exit_bt.Location = new System.Drawing.Point(264, 113);
            this.exit_bt.Name = "exit_bt";
            this.exit_bt.Size = new System.Drawing.Size(264, 58);
            this.exit_bt.TabIndex = 0;
            this.exit_bt.Text = "Bezárás";
            this.exit_bt.UseVisualStyleBackColor = true;
            this.exit_bt.Click += new System.EventHandler(this.exit_bt_Click);
            // 
            // ellenorzes_bt
            // 
            this.ellenorzes_bt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ellenorzes_bt.ForeColor = System.Drawing.Color.DarkBlue;
            this.ellenorzes_bt.Location = new System.Drawing.Point(-6, 113);
            this.ellenorzes_bt.Name = "ellenorzes_bt";
            this.ellenorzes_bt.Size = new System.Drawing.Size(275, 58);
            this.ellenorzes_bt.TabIndex = 1;
            this.ellenorzes_bt.Text = "Ellenőrzés";
            this.ellenorzes_bt.UseVisualStyleBackColor = true;
            this.ellenorzes_bt.Click += new System.EventHandler(this.ellenorzes_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Az új feladvány mérete:";
            // 
            // minus_bt
            // 
            this.minus_bt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minus_bt.Location = new System.Drawing.Point(135, 20);
            this.minus_bt.Name = "minus_bt";
            this.minus_bt.Size = new System.Drawing.Size(30, 27);
            this.minus_bt.TabIndex = 3;
            this.minus_bt.Text = "-";
            this.minus_bt.UseVisualStyleBackColor = true;
            this.minus_bt.Click += new System.EventHandler(this.minus_bt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(22, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "4";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // plus_bt
            // 
            this.plus_bt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.plus_bt.Location = new System.Drawing.Point(199, 21);
            this.plus_bt.Name = "plus_bt";
            this.plus_bt.Size = new System.Drawing.Size(30, 27);
            this.plus_bt.TabIndex = 5;
            this.plus_bt.Text = "+";
            this.plus_bt.UseVisualStyleBackColor = true;
            this.plus_bt.Click += new System.EventHandler(this.plus_bt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kezdőállapot:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(334, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // hossz_lb
            // 
            this.hossz_lb.AutoSize = true;
            this.hossz_lb.Location = new System.Drawing.Point(384, 86);
            this.hossz_lb.Name = "hossz_lb";
            this.hossz_lb.Size = new System.Drawing.Size(48, 13);
            this.hossz_lb.TabIndex = 8;
            this.hossz_lb.Text = "Hossz: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(524, 171);
            this.Controls.Add(this.hossz_lb);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plus_bt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.minus_bt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ellenorzes_bt);
            this.Controls.Add(this.exit_bt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SudokuGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_bt;
        private System.Windows.Forms.Button ellenorzes_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minus_bt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button plus_bt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label hossz_lb;
    }
}

