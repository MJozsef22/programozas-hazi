using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matekbeadando
{
    public partial class Form1 : Form
    {
        static bool gm1 = false;
        static bool gm2 = false;
        static bool gm3 = false;
        static bool gm4 = false;
        static bool gm5 = false;
        static bool gm6 = false;


        


        public Form1()
        {
            InitializeComponent();
        }

        private void kilepes_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void x1_tbx_TextChanged(object sender, EventArgs e)
        {
            gm1 = true;
            if (gm1 && gm2 && gm3 && gm4 && gm5 && gm6) { szamolas_bt.Enabled = true; }
            if (x1_tbx.Text == "")
            {
                szamolas_bt.Enabled = false;
            }
        }

        private void y1_tbx_TextChanged(object sender, EventArgs e)
        {
            gm2 = true; if (gm1 && gm2 && gm3 && gm4 && gm5 && gm6) { szamolas_bt.Enabled = true; }
            if (y1_tbx.Text == "")
            {
                szamolas_bt.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            gm3 = true; if (gm1 && gm2 && gm3 && gm4 && gm5 && gm6) { szamolas_bt.Enabled = true; }
            if (x2_tbx.Text == "")
            {
                szamolas_bt.Enabled = false;
            }
        }

        private void y2_tbx_TextChanged(object sender, EventArgs e)
        {
            gm4 = true; if (gm1 && gm2 && gm3 && gm4 && gm5 && gm6) { szamolas_bt.Enabled = true; }
            if (y2_tbx.Text == "")
            {
                szamolas_bt.Enabled = false;
            }
        }

        private void m_tbx_TextChanged(object sender, EventArgs e)
        {
            gm5 = true; if (gm1 && gm2 && gm3 && gm4 && gm5 && gm6) { szamolas_bt.Enabled = true; }
            if (m_tbx.Text == "")
            {
                szamolas_bt.Enabled = false;
            }
        }

        private void n_tbx_TextChanged(object sender, EventArgs e)
        {
            gm6 = true;
            if (gm1 && gm2 && gm3 && gm4 && gm5 && gm6) { szamolas_bt.Enabled = true; }
            if (n_tbx.Text == "")
            {
                szamolas_bt.Enabled = false;
            }
        }

        private void szamolas_bt_Click(object sender, EventArgs e)
        {
            int x1, y1, x2, y2, m, n = 0;
            x1 = int.Parse(x1_tbx.Text);
            y1 = int.Parse(y1_tbx.Text);
            x2 = int.Parse(x2_tbx.Text);
            y2 = int.Parse(y2_tbx.Text);
            m = int.Parse(m_tbx.Text);
            n = int.Parse(n_tbx.Text);
            int aranyossz = m + n;
            double x = (n * x1) + (m * x2);
            double y = (n * y1) + (m * y2);
            double eredmenyX = Math.Round((x / aranyossz ),2) ;
            double eredmenyY = Math.Round((y/ aranyossz) , 2);

            Eredmenyek_lbx.Items.Add($"x:{eredmenyX} y:{eredmenyY}\n");

        }

        private void Eredmenyek_lbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}


