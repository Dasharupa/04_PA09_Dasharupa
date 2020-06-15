using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_PA09_Dasharupa
{
    public partial class Form1 : Form
    {
        private double exchangeRate;

        public Form1()
        {
            InitializeComponent();

            exchangeRate = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            exchangeRate = 81.97;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Converted.Text = String.Empty;
            txt_Amount.Text = String.Empty;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Convert_Click_1(object sender, EventArgs e)
        {
            double result;
            if(double.TryParse(txt_Amount.Text, out result))
            {
                txt_Converted.Text = (result * exchangeRate).ToString();
            }

            if (String.IsNullOrEmpty(txt_Converted.Text))
            {
                MessageBox.Show("Please enter a valid amount");
                return;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(txt_Amount.Text, "[-,+,/,=]"))
            {
                MessageBox.Show("Please enter a valid amount");
                return;
            }
        }

        private void rb_US_CheckedChanged(object sender, EventArgs e)
        {
            exchangeRate = 0.74;
        }
    }
}
