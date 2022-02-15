namespace lottoGUI
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
            this.first_bt = new System.Windows.Forms.Button();
            this.second_bt = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.eredmenyek_lbx = new System.Windows.Forms.ListBox();
            this.missing_lbx = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // first_bt
            // 
            this.first_bt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.first_bt.Location = new System.Drawing.Point(63, 311);
            this.first_bt.Name = "first_bt";
            this.first_bt.Size = new System.Drawing.Size(165, 56);
            this.first_bt.TabIndex = 0;
            this.first_bt.Text = "10.feladat";
            this.first_bt.UseVisualStyleBackColor = true;
            this.first_bt.Click += new System.EventHandler(this.first_bt_Click);
            // 
            // second_bt
            // 
            this.second_bt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.second_bt.Location = new System.Drawing.Point(358, 311);
            this.second_bt.Name = "second_bt";
            this.second_bt.Size = new System.Drawing.Size(165, 56);
            this.second_bt.TabIndex = 1;
            this.second_bt.Text = "11.feladat";
            this.second_bt.UseVisualStyleBackColor = true;
            this.second_bt.Click += new System.EventHandler(this.second_bt_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit.ForeColor = System.Drawing.Color.Crimson;
            this.exit.Location = new System.Drawing.Point(545, 368);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(165, 56);
            this.exit.TabIndex = 2;
            this.exit.Text = "Bezárás";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // eredmenyek_lbx
            // 
            this.eredmenyek_lbx.FormattingEnabled = true;
            this.eredmenyek_lbx.Location = new System.Drawing.Point(63, 91);
            this.eredmenyek_lbx.Name = "eredmenyek_lbx";
            this.eredmenyek_lbx.Size = new System.Drawing.Size(164, 186);
            this.eredmenyek_lbx.TabIndex = 3;
            // 
            // missing_lbx
            // 
            this.missing_lbx.FormattingEnabled = true;
            this.missing_lbx.Location = new System.Drawing.Point(358, 91);
            this.missing_lbx.Name = "missing_lbx";
            this.missing_lbx.Size = new System.Drawing.Size(164, 186);
            this.missing_lbx.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(49, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kihuzott számok listája:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(321, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nem kihuzott számok listája:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(708, 419);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.missing_lbx);
            this.Controls.Add(this.eredmenyek_lbx);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.second_bt);
            this.Controls.Add(this.first_bt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button first_bt;
        private System.Windows.Forms.Button second_bt;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ListBox eredmenyek_lbx;
        private System.Windows.Forms.ListBox missing_lbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

