namespace matekbeadando
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
            this.kilepes_bt = new System.Windows.Forms.Button();
            this.szamolas_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.x1_tbx = new System.Windows.Forms.TextBox();
            this.x2_tbx = new System.Windows.Forms.TextBox();
            this.Eredmenyek_lbx = new System.Windows.Forms.ListBox();
            this.y1_tbx = new System.Windows.Forms.TextBox();
            this.y2_tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.m_tbx = new System.Windows.Forms.TextBox();
            this.n_tbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kilepes_bt
            // 
            this.kilepes_bt.BackColor = System.Drawing.Color.Linen;
            this.kilepes_bt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kilepes_bt.ForeColor = System.Drawing.Color.Crimson;
            this.kilepes_bt.Location = new System.Drawing.Point(296, 280);
            this.kilepes_bt.Name = "kilepes_bt";
            this.kilepes_bt.Size = new System.Drawing.Size(315, 128);
            this.kilepes_bt.TabIndex = 0;
            this.kilepes_bt.Text = "Kilépés";
            this.kilepes_bt.UseVisualStyleBackColor = false;
            this.kilepes_bt.Click += new System.EventHandler(this.kilepes_bt_Click);
            // 
            // szamolas_bt
            // 
            this.szamolas_bt.BackColor = System.Drawing.Color.DarkCyan;
            this.szamolas_bt.Enabled = false;
            this.szamolas_bt.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szamolas_bt.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.szamolas_bt.Location = new System.Drawing.Point(-2, 280);
            this.szamolas_bt.Name = "szamolas_bt";
            this.szamolas_bt.Size = new System.Drawing.Size(310, 128);
            this.szamolas_bt.TabIndex = 1;
            this.szamolas_bt.Text = "Számolás";
            this.szamolas_bt.UseVisualStyleBackColor = false;
            this.szamolas_bt.Click += new System.EventHandler(this.szamolas_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adjuk meg a koordinátkákat amely a sík két pontja és egy aránypár segítségével ki" +
    "számolja a \r\nkét pont által meghatározott  szakasz  adott  arányú  osztópontjána" +
    "k  koordinátáit!\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(29, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(29, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "B:";
            // 
            // x1_tbx
            // 
            this.x1_tbx.Location = new System.Drawing.Point(55, 86);
            this.x1_tbx.Name = "x1_tbx";
            this.x1_tbx.Size = new System.Drawing.Size(21, 20);
            this.x1_tbx.TabIndex = 5;
            this.x1_tbx.TextChanged += new System.EventHandler(this.x1_tbx_TextChanged);
            // 
            // x2_tbx
            // 
            this.x2_tbx.Location = new System.Drawing.Point(55, 130);
            this.x2_tbx.Name = "x2_tbx";
            this.x2_tbx.Size = new System.Drawing.Size(21, 20);
            this.x2_tbx.TabIndex = 6;
            this.x2_tbx.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Eredmenyek_lbx
            // 
            this.Eredmenyek_lbx.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Eredmenyek_lbx.FormattingEnabled = true;
            this.Eredmenyek_lbx.ItemHeight = 19;
            this.Eredmenyek_lbx.Location = new System.Drawing.Point(351, 104);
            this.Eredmenyek_lbx.Name = "Eredmenyek_lbx";
            this.Eredmenyek_lbx.Size = new System.Drawing.Size(243, 156);
            this.Eredmenyek_lbx.TabIndex = 7;
            this.Eredmenyek_lbx.SelectedIndexChanged += new System.EventHandler(this.Eredmenyek_lbx_SelectedIndexChanged);
            // 
            // y1_tbx
            // 
            this.y1_tbx.Location = new System.Drawing.Point(97, 86);
            this.y1_tbx.Name = "y1_tbx";
            this.y1_tbx.Size = new System.Drawing.Size(21, 20);
            this.y1_tbx.TabIndex = 8;
            this.y1_tbx.TextChanged += new System.EventHandler(this.y1_tbx_TextChanged);
            // 
            // y2_tbx
            // 
            this.y2_tbx.Location = new System.Drawing.Point(97, 130);
            this.y2_tbx.Name = "y2_tbx";
            this.y2_tbx.Size = new System.Drawing.Size(21, 20);
            this.y2_tbx.TabIndex = 9;
            this.y2_tbx.TextChanged += new System.EventHandler(this.y2_tbx_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(79, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = ";";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(79, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = ";";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(210, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Eredmények(kettő tizdes jegyre kerekítve):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(29, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Arány érték:";
            // 
            // m_tbx
            // 
            this.m_tbx.Location = new System.Drawing.Point(113, 185);
            this.m_tbx.Name = "m_tbx";
            this.m_tbx.Size = new System.Drawing.Size(21, 20);
            this.m_tbx.TabIndex = 14;
            this.m_tbx.TextChanged += new System.EventHandler(this.m_tbx_TextChanged);
            // 
            // n_tbx
            // 
            this.n_tbx.Location = new System.Drawing.Point(159, 185);
            this.n_tbx.Name = "n_tbx";
            this.n_tbx.Size = new System.Drawing.Size(21, 20);
            this.n_tbx.TabIndex = 15;
            this.n_tbx.TextChanged += new System.EventHandler(this.n_tbx_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(136, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(609, 406);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.n_tbx);
            this.Controls.Add(this.m_tbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.y2_tbx);
            this.Controls.Add(this.y1_tbx);
            this.Controls.Add(this.Eredmenyek_lbx);
            this.Controls.Add(this.x2_tbx);
            this.Controls.Add(this.x1_tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.szamolas_bt);
            this.Controls.Add(this.kilepes_bt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kilepes_bt;
        private System.Windows.Forms.Button szamolas_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox x1_tbx;
        private System.Windows.Forms.TextBox x2_tbx;
        private System.Windows.Forms.ListBox Eredmenyek_lbx;
        private System.Windows.Forms.TextBox y1_tbx;
        private System.Windows.Forms.TextBox y2_tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox m_tbx;
        private System.Windows.Forms.TextBox n_tbx;
        private System.Windows.Forms.Label label8;
    }
}

