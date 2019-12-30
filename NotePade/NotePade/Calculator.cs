using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotePade.Presenters;

namespace NotePade
{
    public partial class Calculator : Form
    {
        CalcPresenter C;

        int k; //количество нажатий кнопки MRC

        public Calculator()
        {
            InitializeComponent();

            C = new CalcPresenter();

            labelNumber.Text = "0";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            labelNumber.Text = "0";

            C.Clear_A();
            FreeButtons();

            k = 0;
        }
        private void ButtonChangeSign_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text[0] == '-')
                labelNumber.Text = labelNumber.Text.Remove(0, 1);
            else
                labelNumber.Text = "-" + labelNumber.Text;
        }
        private void ButtonPoint_Click(object sender, EventArgs e)
        {
            if ((labelNumber.Text.IndexOf(",") == -1) && (labelNumber.Text.IndexOf("∞") == -1))
                labelNumber.Text += ",";
        }
        private void Button0_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "0";

            CorrectNumber();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "1";

            CorrectNumber();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "2";

            CorrectNumber();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "3";

            CorrectNumber();
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "4";

            CorrectNumber();
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "5";

            CorrectNumber();
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "6";

            CorrectNumber();
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "7";

            CorrectNumber();
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "8";

            CorrectNumber();
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "9";

            CorrectNumber();
        }
        //удаляем лишний ноль впереди числа, если таковой имеется
        private void CorrectNumber()
        {
            //если есть знак "бесконечность" - не даёт писать цифры после него
            if (labelNumber.Text.IndexOf("∞") != -1)
                labelNumber.Text = labelNumber.Text.Substring(0, labelNumber.Text.Length - 1);

            //ситуация: слева ноль, а после него НЕ запятая, тогда ноль можно удалить
            if (labelNumber.Text[0] == '0' && (labelNumber.Text.IndexOf(",") != 1))
                labelNumber.Text = labelNumber.Text.Remove(0, 1);

            //аналогично предыдущему, только для отрицательного числа
            if (labelNumber.Text[0] == '-')
                if (labelNumber.Text[1] == '0' && (labelNumber.Text.IndexOf(",") != 2))
                    labelNumber.Text = labelNumber.Text.Remove(1, 1);
        }
        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            if (!buttonMult.Enabled)
                labelNumber.Text = C.Multiplication(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonDiv.Enabled)
                labelNumber.Text = C.Division(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonPlus.Enabled)
                labelNumber.Text = C.Sum(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonMinus.Enabled)
                labelNumber.Text = C.Subtraction(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonSqrtX.Enabled)
                labelNumber.Text = C.SqrtX(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonDegreeY.Enabled)
                labelNumber.Text = C.DegreeY(Convert.ToDouble(labelNumber.Text)).ToString();

            C.Clear_A();
            FreeButtons();

            k = 0;
        }
        private void ButtonMult_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonMult.Enabled = false;

                labelNumber.Text = "0";
            }
        }
        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonDiv.Enabled = false;

                labelNumber.Text = "0";
            }
        }
        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonPlus.Enabled = false;

                labelNumber.Text = "0";
            }
        }
        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonMinus.Enabled = false;

                labelNumber.Text = "0";
            }
        }
        private void ButtonSqrtX_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonDegreeY.Enabled = false;

                labelNumber.Text = "0";
            }
        }
        private void ButtonDegreeY_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonDegreeY.Enabled = false;

                labelNumber.Text = "0";
            }
        }
        private void ButtonSqrt_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                labelNumber.Text = C.Sqrt().ToString();

                C.Clear_A();
                FreeButtons();
            }
        }
        private void ButtonSquare_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                labelNumber.Text = C.Square().ToString();

                C.Clear_A();
                FreeButtons();
            }
        }
        private void ButtonFactorial_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                if ((Convert.ToDouble(labelNumber.Text) == (int)(Convert.ToDouble(labelNumber.Text))) &&
                    ((Convert.ToDouble(labelNumber.Text) >= 0.0)))
                {
                    C.Put_A(Convert.ToDouble(labelNumber.Text));

                    labelNumber.Text = C.Factorial().ToString();

                    C.Clear_A();
                    FreeButtons();
                }
                else
                    MessageBox.Show("Число должно быть >= 0 и целым!");
            }
        }
        private void ButtonMPlus_Click(object sender, EventArgs e)
        {
            C.M_Sum(Convert.ToDouble(labelNumber.Text));
        }
        private void ButtonMMinus_Click(object sender, EventArgs e)
        {
            C.M_Subtraction(Convert.ToDouble(labelNumber.Text));
        }
        private void ButtonMMult_Click(object sender, EventArgs e)
        {
            C.M_Multiplication(Convert.ToDouble(labelNumber.Text));
        }
        private void ButtonMDiv_Click(object sender, EventArgs e)
        {
            C.M_Division(Convert.ToDouble(labelNumber.Text));
        }
        private void ButtonMRC_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                k++;

                if (k == 1)
                    labelNumber.Text = C.MemoryShow().ToString();

                if (k == 2)
                {
                    C.Memory_Clear();
                    labelNumber.Text = "0";

                    k = 0;
                }
            }
        }
        private bool CanPress()
        {
            if (!buttonMult.Enabled)
                return false;

            if (!buttonDiv.Enabled)
                return false;

            if (!buttonPlus.Enabled)
                return false;

            if (!buttonMinus.Enabled)
                return false;

            if (!buttonSqrtX.Enabled)
                return false;

            if (!buttonDegreeY.Enabled)
                return false;

            return true;
        }
        //снятие нажатия всех кнопок мат.операций
        private void FreeButtons()
        {
            buttonMult.Enabled = true;
            buttonDiv.Enabled = true;
            buttonPlus.Enabled = true;
            buttonMinus.Enabled = true;
            buttonSqrtX.Enabled = true;
            buttonDegreeY.Enabled = true;
        }
    }
}

