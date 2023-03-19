using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EletjatekGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 15;
            comboBox2.SelectedIndex = 15;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType().Name=="CheckBox")
                {
                    this.Controls.Remove(item);
                }
            }

            int x = int.Parse(comboBox1.Text);
            int y = int.Parse(comboBox2.Text);

            int pluszx = 20;
            int pluszy = 18;
            for (int i = 0; i <= x; i++)
            {
                
                for (int j = 0; j <= y; j++)
                {
                    CheckBox box = new CheckBox();
                    box.Size = new Size(20, 20);
                    box.Location = new Point(20 + (pluszx * i), 130 + (pluszy * j));
                    this.Controls.Add(box);
                }

            }

            




        }
    }
}
