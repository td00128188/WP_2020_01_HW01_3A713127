using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_2020_01_HW01_3A713127
{
    public partial class Form1 : Form
    {
        string[] name = new string[] { };
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MD5 md5 = MD5.Create();
            byte[] source = Encoding.Default.GetBytes(tb1.Text);
            byte[] crypto = md5.ComputeHash(source);
            string result = Convert.ToBase64String(crypto);
            rtb1.Text = result;
            if(tb1.Text == "")
            {
                rtb1.Text = "";
            }
        }

        private void rtb1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
