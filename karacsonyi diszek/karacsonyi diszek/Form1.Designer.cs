namespace karacsonyi_diszek
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
            this.kiiras_lbx = new System.Windows.Forms.ListBox();
            this.add_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.elkeszitett_ertek_tb = new System.Windows.Forms.TextBox();
            this.eladott_ertek_tb = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.hiba_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kiiras_lbx
            // 
            this.kiiras_lbx.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kiiras_lbx.FormattingEnabled = true;
            this.kiiras_lbx.ItemHeight = 17;
            this.kiiras_lbx.Location = new System.Drawing.Point(15, 180);
            this.kiiras_lbx.Name = "kiiras_lbx";
            this.kiiras_lbx.Size = new System.Drawing.Size(528, 191);
            this.kiiras_lbx.TabIndex = 0;
            // 
            // add_bt
            // 
            this.add_bt.Enabled = false;
            this.add_bt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.add_bt.Location = new System.Drawing.Point(549, 255);
            this.add_bt.Name = "add_bt";
            this.add_bt.Size = new System.Drawing.Size(150, 40);
            this.add_bt.TabIndex = 1;
            this.add_bt.Text = "Hozzáad";
            this.add_bt.UseVisualStyleBackColor = true;
            this.add_bt.Click += new System.EventHandler(this.add_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(448, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eladott:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(238, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elkészített:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nap száma:";
            // 
            // elkeszitett_ertek_tb
            // 
            this.elkeszitett_ertek_tb.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.elkeszitett_ertek_tb.Location = new System.Drawing.Point(328, 63);
            this.elkeszitett_ertek_tb.Name = "elkeszitett_ertek_tb";
            this.elkeszitett_ertek_tb.Size = new System.Drawing.Size(100, 25);
            this.elkeszitett_ertek_tb.TabIndex = 5;
            this.elkeszitett_ertek_tb.Text = "0";
            this.elkeszitett_ertek_tb.TextChanged += new System.EventHandler(this.elkeszitett_ertek_tb_TextChanged);
            // 
            // eladott_ertek_tb
            // 
            this.eladott_ertek_tb.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.eladott_ertek_tb.Location = new System.Drawing.Point(514, 61);
            this.eladott_ertek_tb.Name = "eladott_ertek_tb";
            this.eladott_ertek_tb.Size = new System.Drawing.Size(100, 25);
            this.eladott_ertek_tb.TabIndex = 6;
            this.eladott_ertek_tb.Text = "0";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.comboBox1.Location = new System.Drawing.Point(102, 65);
            this.comboBox1.MaxLength = 40;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // hiba_lb
            // 
            this.hiba_lb.AutoSize = true;
            this.hiba_lb.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.hiba_lb.Location = new System.Drawing.Point(429, 115);
            this.hiba_lb.Name = "hiba_lb";
            this.hiba_lb.Size = new System.Drawing.Size(0, 17);
            this.hiba_lb.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(706, 383);
            this.Controls.Add(this.hiba_lb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.eladott_ertek_tb);
            this.Controls.Add(this.elkeszitett_ertek_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_bt);
            this.Controls.Add(this.kiiras_lbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Angyalka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox kiiras_lbx;
        private System.Windows.Forms.Button add_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox elkeszitett_ertek_tb;
        private System.Windows.Forms.TextBox eladott_ertek_tb;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label hiba_lb;
    }
}

