using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//https://metanit.com/sharp/windowsforms/4.22.php error example

//https://beregifiguru.ru/%D0%9A%D0%B0%D0%BB%D1%8C%D0%BA%D1%83%D0%BB%D1%8F%D1%82%D0%BE%D1%80%D1%8B/%D0%A0%D0%B0%D1%81%D1%87%D0%B5%D1%82-%D0%BA%D0%B0%D0%BB%D0%BE%D1%80%D0%B8%D0%B9
//Example calculator calories 

//https://www.adme.ru/svoboda-sdelaj-sam/odna-prostaya-formula-kotoraya-podschitaet-kakoe-kolichestvo-kalorij-v-den-pozvolit-vam-est-i-hudet-1687165/
//Calculation formulas

namespace CalculateForTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rb_Male.Checked = true;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btn_SedenteryLifestyle, "If you are not strenuous and sedentary");
            toolTip.SetToolTip(btn_OrdinaryLifestyle, "If you do sports with an average load 3 - 5 times a week");
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

        Count count;

        private void btn_LoseWeight_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tb_Weight.Text))
                {
                    tb_Weight.BackColor = Color.Red;
                }
                if (string.IsNullOrEmpty(tb_Age.Text))
                {
                    tb_Age.BackColor = Color.Red;
                }
                int weight = Convert.ToInt32(tb_Weight.Text);
                int growth = Convert.ToInt32(tb_Growth.Text);
                int age = Convert.ToInt32(tb_Age.Text);
                bool check = rb_Male.Checked;

                count = new Count(weight, growth, age, check);

                double res = count.LoseWeight();
                lbl_Answer.Text = Convert.ToString(res);
            }
            catch { }


        }

        private void btn_GainWeight_Click(object sender, EventArgs e)
        {
            try
            {
                int weight = Convert.ToInt32(tb_Weight.Text);
                int growth = Convert.ToInt32(tb_Growth.Text);
                int age = Convert.ToInt32(tb_Age.Text);
                bool check = rb_Male.Checked;

                count = new Count(weight, growth, age, check);

                double res = count.GainWeight();
                lbl_Answer.Text = Convert.ToString(res);
            }
            catch { }
        }

        private void btn_MaintainWeight_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tb_Weight.Text))
                {
                    tb_Weight.BackColor = Color.Red;
                }
                if (string.IsNullOrEmpty(tb_Age.Text))
                {
                    tb_Age.BackColor = Color.Red;
                }
                int weight = Convert.ToInt32(tb_Weight.Text);
                int growth = Convert.ToInt32(tb_Growth.Text);
                int age = Convert.ToInt32(tb_Age.Text);
                bool check = rb_Male.Checked;

                count = new Count(weight, growth, age, check);

                double res = count.MaintainWeight();
                lbl_Answer.Text = Convert.ToString(res);

                if (numUD_DesiredWeight.Value > 0)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Form1 newForm1 = new Form1();
                        newForm1.Show();
                    }
                }
            }
            catch { }
        }

        private void tb_Weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void tb_Growth_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
