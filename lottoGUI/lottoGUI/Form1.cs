using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lottoGUI
{
    public partial class Form1 : Form
    {
        List<int> nums = new List<int>();
        Random rnd = new Random();
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        List<string> primes = new List<string>();
        int[] primS = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89};

        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void first_bt_Click(object sender, EventArgs e)
        {
            for(int i = 0;i<=20;i++) 
            {
                nums.Add(rnd.Next(1,91));
            }

            

            foreach (var item in nums)
            {
                if (!dictionary.ContainsKey(item.ToString()))
                {
                    dictionary.Add(item.ToString(),1);
                }
                else
                {
                    dictionary[item.ToString()]++;
                }
            }
            
            foreach (var item in dictionary)
            {
                string text = $"{item.Key}  {item.Value}";
                eredmenyek_lbx.Items.Add(text) ;
            }
        }

        private void second_bt_Click(object sender, EventArgs e)
        {
            

            foreach (var item in primS)
            {
                
                if (!dictionary.ContainsKey(item.ToString()))
                {

                  missing_lbx.Items.Add(item.ToString());

                }
            }
        }
    }
}
