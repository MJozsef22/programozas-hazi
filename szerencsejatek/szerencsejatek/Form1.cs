using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szerencsejatek
{
    public partial class Ablak_1 : Form
    {
        public Ablak_1()
        {
            InitializeComponent();
        }

        private void bezar_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eredmeny_tbx_TextChanged(object sender, EventArgs e)
        {
            karakterekszama_cbx.Text = $"Nem megfelelő karakterekszama ({eredmeny_tbx.Text.Length})";
            if (eredmeny_tbx.Text.Length != 14)
            {
                karakterekszama_cbx.Checked = true;
            }
            else
            {
                karakterekszama_cbx.Checked = false;
            }
            List<char> helytelenkarakterek = new List<char>();
            for (int i = 0; i < eredmeny_tbx.Text.Length; i++)
            {
                if (eredmeny_tbx.Text[i] != '1' || eredmeny_tbx.Text[i] != '2' || eredmeny_tbx.Text[i] != 'X')
                {
                    helytelenkarakterek.Add(eredmeny_tbx.Text[i]);
                    helytelenkarakterek_cbx.Checked = true;
                    helytelenkarakterek_cbx.Text = $"Helytelen karakterek az eredmények ({string.Join(";", helytelenkarakterek)})";
                }
                if (helytelenkarakterek.Count == 0)
                {
                    helytelenkarakterek_cbx.Checked = false;
                    helytelenkarakterek_cbx.Text = $"Helytelen karakterek az eredmények ({string.Join(";", helytelenkarakterek)})";
                }
            }

            if (karakterekszama_cbx.Checked == false && helytelenkarakterek_cbx.Checked == false)
            {
                eredmeny_bt.Enabled = true;
            }
            else
            {
                eredmeny_bt.Enabled = false;
            }

        }
    }
}
