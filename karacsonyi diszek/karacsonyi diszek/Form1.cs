using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karacsonyi_diszek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_bt_Click(object sender, EventArgs e)
        {
            int eladott_ertek = int.Parse(eladott_ertek_tb.Text);
            int elkeszitett_ertek = int.Parse(elkeszitett_ertek_tb.Text);
            if (elkeszitett_ertek < 0)
            {
                hiba_lb.Text = "A szám nem lehet minusz!";
            }
            if (elkeszitett_ertek < eladott_ertek)
            {
                hiba_lb.Text = "Túl sok az eladott angyalka!";
            }
            kiiras_lbx.Items.Add($"{comboBox1.SelectedItem}.nap:\t {elkeszitett_ertek}\t {eladott_ertek} =\t {elkeszitett_ertek- eladott_ertek}\n");
            elkeszitett_ertek_tb.Text = eladott_ertek_tb.Text = "0";
            for (int i = comboBox1.SelectedIndex; i >= 0; i--)
            {
                comboBox1.Items.RemoveAt(i);
            }
        }

        private void elkeszitett_ertek_tb_TextChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_bt.Enabled = true;
        }
    }
}
