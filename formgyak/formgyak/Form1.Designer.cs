namespace formgyak
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
            this.bezaras_bt = new System.Windows.Forms.Button();
            this.nev_tbx = new System.Windows.Forms.TextBox();
            this.osztaly_tbx = new System.Windows.Forms.TextBox();
            this.eletkor_NUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kiiras_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eletkor_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // bezaras_bt
            // 
            this.bezaras_bt.BackColor = System.Drawing.Color.LightCoral;
            this.bezaras_bt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.bezaras_bt.Location = new System.Drawing.Point(157, 262);
            this.bezaras_bt.Name = "bezaras_bt";
            this.bezaras_bt.Size = new System.Drawing.Size(161, 106);
            this.bezaras_bt.TabIndex = 0;
            this.bezaras_bt.Text = "Bezárás";
            this.bezaras_bt.UseVisualStyleBackColor = false;
            this.bezaras_bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // nev_tbx
            // 
            this.nev_tbx.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold);
            this.nev_tbx.Location = new System.Drawing.Point(36, 56);
            this.nev_tbx.Name = "nev_tbx";
            this.nev_tbx.Size = new System.Drawing.Size(199, 23);
            this.nev_tbx.TabIndex = 2;
            // 
            // osztaly_tbx
            // 
            this.osztaly_tbx.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold);
            this.osztaly_tbx.Location = new System.Drawing.Point(36, 127);
            this.osztaly_tbx.Name = "osztaly_tbx";
            this.osztaly_tbx.Size = new System.Drawing.Size(198, 23);
            this.osztaly_tbx.TabIndex = 3;
            this.osztaly_tbx.TextChanged += new System.EventHandler(this.osztaly_tbx_TextChanged);
            // 
            // eletkor_NUD
            // 
            this.eletkor_NUD.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold);
            this.eletkor_NUD.Location = new System.Drawing.Point(36, 216);
            this.eletkor_NUD.Name = "eletkor_NUD";
            this.eletkor_NUD.Size = new System.Drawing.Size(197, 23);
            this.eletkor_NUD.TabIndex = 4;
            this.eletkor_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add meg a teljes neved!:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(33, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add meg az osztályod!:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(33, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Add meg az élet korod!:";
            // 
            // kiiras_bt
            // 
            this.kiiras_bt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kiiras_bt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kiiras_bt.Location = new System.Drawing.Point(-2, 262);
            this.kiiras_bt.Name = "kiiras_bt";
            this.kiiras_bt.Size = new System.Drawing.Size(165, 106);
            this.kiiras_bt.TabIndex = 8;
            this.kiiras_bt.Text = "Kiírás";
            this.kiiras_bt.UseVisualStyleBackColor = false;
            this.kiiras_bt.Click += new System.EventHandler(this.kiiras_bt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(311, 356);
            this.Controls.Add(this.kiiras_bt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eletkor_NUD);
            this.Controls.Add(this.osztaly_tbx);
            this.Controls.Add(this.nev_tbx);
            this.Controls.Add(this.bezaras_bt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ablak";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eletkor_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bezaras_bt;
        private System.Windows.Forms.TextBox nev_tbx;
        private System.Windows.Forms.TextBox osztaly_tbx;
        private System.Windows.Forms.NumericUpDown eletkor_NUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kiiras_bt;
    }
}

