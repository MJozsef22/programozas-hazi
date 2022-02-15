using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            int[] nums = new int[8];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(1, 20);
            }
            plusBal_tbx.Text = nums[0].ToString();
            plusJobb_tbx.Text = nums[1].ToString();
            minusBal_tbx.Text = nums[2].ToString();
            minusJobb_tbx.Text = nums[3].ToString();
            multBal_tbx.Text = nums[4].ToString();
            multJobb_tbx.Text = nums[5].ToString();
            divBal_tbx.Text = nums[6].ToString();
            divJobb_tbx.Text = nums[7].ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A program bezár!");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int.Parse(plusBal_tbx.Text) + int.Parse(plusJobb_tbx.Text)) == int.Parse(plusEredmeny_tbx.Text))
            {
                plusEredmeny_tbx.ForeColor = Color.Green;
            }
            else
            {
                plusEredmeny_tbx.ForeColor = Color.Red;
            }
            if (int.Parse(minusBal_tbx.Text) - int.Parse(minusJobb_tbx.Text) == int.Parse(minusEredmeny_tbx.Text))
            {
                minusEredmeny_tbx.ForeColor = Color.Green;
            }
            else
            {
                minusEredmeny_tbx.ForeColor = Color.Red;
            }
            if (int.Parse(multBal_tbx.Text) * int.Parse(multJobb_tbx.Text) == int.Parse(multEredmeny_tbx.Text))
            {
                multEredmeny_tbx.ForeColor = Color.Green;
            }
            else
            {
                multEredmeny_tbx.ForeColor = Color.Red;
            }

            
            if (int.Parse(divBal_tbx.Text) / int.Parse(divJobb_tbx.Text) == double.Parse(divEredmeny_tbx.Text))
            {
                
                divEredmeny_tbx.ForeColor = Color.Green;
            }
            else
            {
                divEredmeny_tbx.ForeColor = Color.Red;
            }


        }
    }
}
