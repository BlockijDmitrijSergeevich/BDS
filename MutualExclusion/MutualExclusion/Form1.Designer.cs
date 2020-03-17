namespace MutualExclusion
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourceText = new System.Windows.Forms.TextBox();
            this.resultText = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numberSource = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.alternation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceText
            // 
            this.sourceText.Location = new System.Drawing.Point(12, 33);
            this.sourceText.Name = "sourceText";
            this.sourceText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sourceText.Size = new System.Drawing.Size(374, 22);
            this.sourceText.TabIndex = 0;
            this.sourceText.Text = "\r\n";
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(12, 78);
            this.resultText.Multiline = true;
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(374, 95);
            this.resultText.TabIndex = 1;
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(12, 179);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(374, 375);
            this.info.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result";
            // 
            // resultNum
            // 
            this.resultNum.Location = new System.Drawing.Point(453, 108);
            this.resultNum.Name = "resultNum";
            this.resultNum.Size = new System.Drawing.Size(256, 22);
            this.resultNum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result";
            // 
            // numberSource
            // 
            this.numberSource.DecimalPlaces = 4;
            this.numberSource.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberSource.Location = new System.Drawing.Point(453, 30);
            this.numberSource.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberSource.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numberSource.Name = "numberSource";
            this.numberSource.Size = new System.Drawing.Size(256, 22);
            this.numberSource.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Peterson";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // alternation
            // 
            this.alternation.Location = new System.Drawing.Point(392, 505);
            this.alternation.Name = "alternation";
            this.alternation.Size = new System.Drawing.Size(134, 49);
            this.alternation.TabIndex = 11;
            this.alternation.Text = "Strict alternation";
            this.alternation.UseVisualStyleBackColor = true;
            this.alternation.Click += new System.EventHandler(this.Alternation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 566);
            this.Controls.Add(this.alternation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numberSource);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.sourceText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numberSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourceText;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numberSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button alternation;
    }
}

