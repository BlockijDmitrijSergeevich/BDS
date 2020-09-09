using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//https://metanit.com/sharp/windowsforms/4.22.php
namespace CalculateForTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label_btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1();
            newForm1.Show();
        }

        private void lbl_btn_about_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.Show();
        }

        private void btn_Count_Click(object sender, EventArgs e)
        {
            int answer = (int)(numUD_Protein.Value * 4 + numUD_Fat.Value * 9 + numUD_Carvohydrates.Value * 4);
            lbl_Answer.Text = Convert.ToString(answer);
        }
    }
}
