namespace NotePade
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMRC = new System.Windows.Forms.Button();
            this.labelNumber = new System.Windows.Forms.Label();
            this.buttonChangeSign = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonMDiv = new System.Windows.Forms.Button();
            this.buttonMMult = new System.Windows.Forms.Button();
            this.buttonMMinus = new System.Windows.Forms.Button();
            this.buttonMPlus = new System.Windows.Forms.Button();
            this.buttonSqrtX = new System.Windows.Forms.Button();
            this.buttonFactorial = new System.Windows.Forms.Button();
            this.buttonDegreeY = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMRC
            // 
            this.buttonMRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonMRC.Location = new System.Drawing.Point(47, 110);
            this.buttonMRC.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMRC.Name = "buttonMRC";
            this.buttonMRC.Size = new System.Drawing.Size(93, 47);
            this.buttonMRC.TabIndex = 58;
            this.buttonMRC.Text = "МRC";
            this.buttonMRC.UseVisualStyleBackColor = true;
            this.buttonMRC.Click += new System.EventHandler(this.ButtonMRC_Click);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F);
            this.labelNumber.Location = new System.Drawing.Point(313, 19);
            this.labelNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(311, 52);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "0123456789.0";
           
            // 
            // buttonChangeSign
            // 
            this.buttonChangeSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonChangeSign.Location = new System.Drawing.Point(565, 110);
            this.buttonChangeSign.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChangeSign.Name = "buttonChangeSign";
            this.buttonChangeSign.Size = new System.Drawing.Size(60, 47);
            this.buttonChangeSign.TabIndex = 57;
            this.buttonChangeSign.Text = "+/-";
            this.buttonChangeSign.UseVisualStyleBackColor = true;
            this.buttonChangeSign.Click += new System.EventHandler(this.ButtonChangeSign_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNumber);
            this.groupBox1.Location = new System.Drawing.Point(20, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(628, 75);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            // 
            // buttonMDiv
            // 
            this.buttonMDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonMDiv.Location = new System.Drawing.Point(416, 110);
            this.buttonMDiv.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMDiv.Name = "buttonMDiv";
            this.buttonMDiv.Size = new System.Drawing.Size(60, 47);
            this.buttonMDiv.TabIndex = 55;
            this.buttonMDiv.Text = "М÷";
            this.buttonMDiv.UseVisualStyleBackColor = true;
            this.buttonMDiv.Click += new System.EventHandler(this.ButtonMDiv_Click);
            // 
            // buttonMMult
            // 
            this.buttonMMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonMMult.Location = new System.Drawing.Point(321, 110);
            this.buttonMMult.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMMult.Name = "buttonMMult";
            this.buttonMMult.Size = new System.Drawing.Size(60, 47);
            this.buttonMMult.TabIndex = 54;
            this.buttonMMult.Text = "М×";
            this.buttonMMult.UseVisualStyleBackColor = true;
            this.buttonMMult.Click += new System.EventHandler(this.ButtonMMult_Click);
            // 
            // buttonMMinus
            // 
            this.buttonMMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonMMinus.Location = new System.Drawing.Point(241, 110);
            this.buttonMMinus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMMinus.Name = "buttonMMinus";
            this.buttonMMinus.Size = new System.Drawing.Size(60, 47);
            this.buttonMMinus.TabIndex = 53;
            this.buttonMMinus.Text = "М-";
            this.buttonMMinus.UseVisualStyleBackColor = true;
            this.buttonMMinus.Click += new System.EventHandler(this.ButtonMMinus_Click);
            // 
            // buttonMPlus
            // 
            this.buttonMPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonMPlus.Location = new System.Drawing.Point(161, 110);
            this.buttonMPlus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMPlus.Name = "buttonMPlus";
            this.buttonMPlus.Size = new System.Drawing.Size(60, 47);
            this.buttonMPlus.TabIndex = 52;
            this.buttonMPlus.Text = "М+";
            this.buttonMPlus.UseVisualStyleBackColor = true;
            this.buttonMPlus.Click += new System.EventHandler(this.ButtonMPlus_Click);
            // 
            // buttonSqrtX
            // 
            this.buttonSqrtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonSqrtX.Location = new System.Drawing.Point(565, 337);
            this.buttonSqrtX.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSqrtX.Name = "buttonSqrtX";
            this.buttonSqrtX.Size = new System.Drawing.Size(60, 47);
            this.buttonSqrtX.TabIndex = 51;
            this.buttonSqrtX.Text = "x√";
            this.buttonSqrtX.UseVisualStyleBackColor = true;
            this.buttonSqrtX.Click += new System.EventHandler(this.ButtonSqrtX_Click);
            // 
            // buttonFactorial
            // 
            this.buttonFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonFactorial.Location = new System.Drawing.Point(565, 476);
            this.buttonFactorial.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFactorial.Name = "buttonFactorial";
            this.buttonFactorial.Size = new System.Drawing.Size(60, 47);
            this.buttonFactorial.TabIndex = 50;
            this.buttonFactorial.Text = "n!";
            this.buttonFactorial.UseVisualStyleBackColor = true;
            this.buttonFactorial.Click += new System.EventHandler(this.ButtonFactorial_Click);
            // 
            // buttonDegreeY
            // 
            this.buttonDegreeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.buttonDegreeY.Location = new System.Drawing.Point(565, 407);
            this.buttonDegreeY.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDegreeY.Name = "buttonDegreeY";
            this.buttonDegreeY.Size = new System.Drawing.Size(60, 47);
            this.buttonDegreeY.TabIndex = 49;
            this.buttonDegreeY.Text = "x^y";
            this.buttonDegreeY.UseVisualStyleBackColor = true;
            this.buttonDegreeY.Click += new System.EventHandler(this.ButtonDegreeY_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.buttonSquare.Location = new System.Drawing.Point(565, 262);
            this.buttonSquare.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(60, 47);
            this.buttonSquare.TabIndex = 48;
            this.buttonSquare.Text = "x^2";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.ButtonSquare_Click);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonSqrt.Location = new System.Drawing.Point(565, 190);
            this.buttonSqrt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(60, 47);
            this.buttonSqrt.TabIndex = 47;
            this.buttonSqrt.Text = "√";
            this.buttonSqrt.UseVisualStyleBackColor = true;
            this.buttonSqrt.Click += new System.EventHandler(this.ButtonSqrt_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCalc.Location = new System.Drawing.Point(321, 476);
            this.buttonCalc.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(155, 47);
            this.buttonCalc.TabIndex = 46;
            this.buttonCalc.Text = "=";
            this.buttonCalc.UseVisualStyleBackColor = false;
            this.buttonCalc.Click += new System.EventHandler(this.ButtonCalc_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonMinus.Location = new System.Drawing.Point(416, 407);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(60, 47);
            this.buttonMinus.TabIndex = 45;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonPlus.Location = new System.Drawing.Point(416, 337);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(60, 47);
            this.buttonPlus.TabIndex = 44;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonDiv.Location = new System.Drawing.Point(416, 263);
            this.buttonDiv.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(60, 47);
            this.buttonDiv.TabIndex = 43;
            this.buttonDiv.Text = "÷";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.ButtonDiv_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonMult.Location = new System.Drawing.Point(416, 190);
            this.buttonMult.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(60, 47);
            this.buttonMult.TabIndex = 42;
            this.buttonMult.Text = "×";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.ButtonMult_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonClear.Location = new System.Drawing.Point(321, 407);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(60, 47);
            this.buttonClear.TabIndex = 41;
            this.buttonClear.Text = "CE";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonPoint.Location = new System.Drawing.Point(241, 407);
            this.buttonPoint.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(60, 47);
            this.buttonPoint.TabIndex = 40;
            this.buttonPoint.Text = ",";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.ButtonPoint_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button4.Location = new System.Drawing.Point(161, 262);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 47);
            this.button4.TabIndex = 39;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(161, 335);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 47);
            this.button1.TabIndex = 38;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button2.Location = new System.Drawing.Point(241, 335);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 47);
            this.button2.TabIndex = 37;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button3.Location = new System.Drawing.Point(321, 337);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 47);
            this.button3.TabIndex = 36;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button0.Location = new System.Drawing.Point(161, 407);
            this.button0.Margin = new System.Windows.Forms.Padding(4);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(60, 47);
            this.button0.TabIndex = 35;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button6.Location = new System.Drawing.Point(321, 263);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 47);
            this.button6.TabIndex = 34;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button5.Location = new System.Drawing.Point(241, 263);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 47);
            this.button5.TabIndex = 33;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button9.Location = new System.Drawing.Point(321, 190);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 47);
            this.button9.TabIndex = 32;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button8.Location = new System.Drawing.Point(241, 190);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 47);
            this.button8.TabIndex = 31;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button7.Location = new System.Drawing.Point(161, 190);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 47);
            this.button7.TabIndex = 30;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 538);
            this.Controls.Add(this.buttonMRC);
            this.Controls.Add(this.buttonChangeSign);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonMDiv);
            this.Controls.Add(this.buttonMMult);
            this.Controls.Add(this.buttonMMinus);
            this.Controls.Add(this.buttonMPlus);
            this.Controls.Add(this.buttonSqrtX);
            this.Controls.Add(this.buttonFactorial);
            this.Controls.Add(this.buttonDegreeY);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMRC;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button buttonChangeSign;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonMDiv;
        private System.Windows.Forms.Button buttonMMult;
        private System.Windows.Forms.Button buttonMMinus;
        private System.Windows.Forms.Button buttonMPlus;
        private System.Windows.Forms.Button buttonSqrtX;
        private System.Windows.Forms.Button buttonFactorial;
        private System.Windows.Forms.Button buttonDegreeY;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
    }
}