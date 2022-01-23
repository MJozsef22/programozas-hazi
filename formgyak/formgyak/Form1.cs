using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formgyak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A program leáll!");
            this.Close();
        }


        private void osztaly_tbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void kiiras_bt_Click(object sender, EventArgs e)
        {
            string nev = Convert.ToString(nev_tbx.Text);
            string osztaly = Convert.ToString(osztaly_tbx.Text);
            decimal kor = Convert.ToDecimal(eletkor_NUD.Value);

            MessageBox.Show($"Diák: {nev}\nosztálya: {osztaly}\nÉletkora: {kor}");
        }
    }
}
