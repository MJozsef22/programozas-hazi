namespace szerencsejatek
{
    partial class Ablak_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ablak_1));
            this.karakterekszama_cbx = new System.Windows.Forms.CheckBox();
            this.helytelenkarakterek_cbx = new System.Windows.Forms.CheckBox();
            this.eredmeny_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eredmeny_tbx = new System.Windows.Forms.TextBox();
            this.bezar_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // karakterekszama_cbx
            // 
            this.karakterekszama_cbx.AutoSize = true;
            this.karakterekszama_cbx.Enabled = false;
            this.karakterekszama_cbx.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.karakterekszama_cbx.Location = new System.Drawing.Point(35, 127);
            this.karakterekszama_cbx.Name = "karakterekszama_cbx";
            this.karakterekszama_cbx.Size = new System.Drawing.Size(272, 23);
            this.karakterekszama_cbx.TabIndex = 0;
            this.karakterekszama_cbx.Text = "Nem megfelelő karakterekszama (14)";
            this.karakterekszama_cbx.UseVisualStyleBackColor = true;
            // 
            // helytelenkarakterek_cbx
            // 
            this.helytelenkarakterek_cbx.AutoSize = true;
            this.helytelenkarakterek_cbx.Enabled = false;
            this.helytelenkarakterek_cbx.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.helytelenkarakterek_cbx.Location = new System.Drawing.Point(35, 176);
            this.helytelenkarakterek_cbx.Name = "helytelenkarakterek_cbx";
            this.helytelenkarakterek_cbx.Size = new System.Drawing.Size(290, 23);
            this.helytelenkarakterek_cbx.TabIndex = 1;
            this.helytelenkarakterek_cbx.Text = "Helytelen karakterek az eredményben ()";
            this.helytelenkarakterek_cbx.UseVisualStyleBackColor = true;
            // 
            // eredmeny_bt
            // 
            this.eredmeny_bt.Enabled = false;
            this.eredmeny_bt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.eredmeny_bt.ForeColor = System.Drawing.Color.DarkGreen;
            this.eredmeny_bt.Location = new System.Drawing.Point(-1, 220);
            this.eredmeny_bt.Name = "eredmeny_bt";
            this.eredmeny_bt.Size = new System.Drawing.Size(266, 61);
            this.eredmeny_bt.TabIndex = 2;
            this.eredmeny_bt.Text = "Eredmény mentése";
            this.eredmeny_bt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kérem a forduló eredményeit[1;2;X]!";
            // 
            // eredmeny_tbx
            // 
            this.eredmeny_tbx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eredmeny_tbx.Location = new System.Drawing.Point(35, 78);
            this.eredmeny_tbx.Name = "eredmeny_tbx";
            this.eredmeny_tbx.Size = new System.Drawing.Size(272, 26);
            this.eredmeny_tbx.TabIndex = 4;
            this.eredmeny_tbx.TextChanged += new System.EventHandler(this.eredmeny_tbx_TextChanged);
            // 
            // bezar_bt
            // 
            this.bezar_bt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bezar_bt.ForeColor = System.Drawing.Color.Red;
            this.bezar_bt.Location = new System.Drawing.Point(258, 220);
            this.bezar_bt.Name = "bezar_bt";
            this.bezar_bt.Size = new System.Drawing.Size(276, 61);
            this.bezar_bt.TabIndex = 5;
            this.bezar_bt.Text = "Bezár";
            this.bezar_bt.UseVisualStyleBackColor = true;
            this.bezar_bt.Click += new System.EventHandler(this.bezar_bt_Click);
            // 
            // Ablak_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(532, 279);
            this.Controls.Add(this.bezar_bt);
            this.Controls.Add(this.eredmeny_tbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eredmeny_bt);
            this.Controls.Add(this.helytelenkarakterek_cbx);
            this.Controls.Add(this.karakterekszama_cbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ablak_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ablak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox karakterekszama_cbx;
        private System.Windows.Forms.CheckBox helytelenkarakterek_cbx;
        private System.Windows.Forms.Button eredmeny_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eredmeny_tbx;
        private System.Windows.Forms.Button bezar_bt;
    }
}

