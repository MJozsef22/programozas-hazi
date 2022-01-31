using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudokuGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_bt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A program leáll");
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            hossz_lb.Text = ($"Hossz: { textBox2.Text.Length}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            if (num == 9)
            {
                plus_bt.Enabled = false;
            }
            else if (num == 4)
            {
                minus_bt.Enabled = false;
            }
            else
            {
                minus_bt.Enabled = true;
                plus_bt.Enabled = true;
            }
        }

        private void plus_bt_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            num++;
            textBox1.Text = num.ToString();
        }

        private void minus_bt_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            num--;
            textBox1.Text = num.ToString();
        }

        private void ellenorzes_bt_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            double negyzetreEmeltszam = Math.Pow(num, 2);
            if (textBox2.TextLength > negyzetreEmeltszam)
            {
                MessageBox.Show($"A feladvány hosszú: törlendő {textBox2.TextLength-negyzetreEmeltszam} számjegy");
            }
            else if (textBox2.TextLength < negyzetreEmeltszam)
            {
                MessageBox.Show($"A feladvány rövid: kell még {-(textBox2.TextLength - negyzetreEmeltszam)} számjegy!");
            }
            
        }
    }
}
