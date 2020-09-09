namespace CalculateForTest
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_btn_about = new System.Windows.Forms.Label();
            this.label_btn_Close = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.numUD_Protein = new System.Windows.Forms.NumericUpDown();
            this.numUD_Fat = new System.Windows.Forms.NumericUpDown();
            this.numUD_Carvohydrates = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Count = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Answer = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Protein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Fat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Carvohydrates)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.lbl_btn_about);
            this.panel1.Controls.Add(this.label_btn_Close);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 28);
            this.panel1.TabIndex = 0;
            // 
            // lbl_btn_about
            // 
            this.lbl_btn_about.AutoSize = true;
            this.lbl_btn_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_btn_about.Location = new System.Drawing.Point(268, 0);
            this.lbl_btn_about.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_btn_about.Name = "lbl_btn_about";
            this.lbl_btn_about.Size = new System.Drawing.Size(24, 26);
            this.lbl_btn_about.TabIndex = 1;
            this.lbl_btn_about.Text = "?";
            this.lbl_btn_about.Click += new System.EventHandler(this.lbl_btn_about_Click);
            // 
            // label_btn_Close
            // 
            this.label_btn_Close.AutoSize = true;
            this.label_btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_btn_Close.Location = new System.Drawing.Point(296, 0);
            this.label_btn_Close.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_btn_Close.Name = "label_btn_Close";
            this.label_btn_Close.Size = new System.Drawing.Size(27, 26);
            this.label_btn_Close.TabIndex = 0;
            this.label_btn_Close.Text = "X";
            this.label_btn_Close.Click += new System.EventHandler(this.label_btn_Close_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(256, 337);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(56, 19);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // numUD_Protein
            // 
            this.numUD_Protein.Location = new System.Drawing.Point(12, 69);
            this.numUD_Protein.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUD_Protein.Name = "numUD_Protein";
            this.numUD_Protein.Size = new System.Drawing.Size(150, 20);
            this.numUD_Protein.TabIndex = 2;
            // 
            // numUD_Fat
            // 
            this.numUD_Fat.Location = new System.Drawing.Point(12, 111);
            this.numUD_Fat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUD_Fat.Name = "numUD_Fat";
            this.numUD_Fat.Size = new System.Drawing.Size(150, 20);
            this.numUD_Fat.TabIndex = 3;
            // 
            // numUD_Carvohydrates
            // 
            this.numUD_Carvohydrates.Location = new System.Drawing.Point(12, 153);
            this.numUD_Carvohydrates.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUD_Carvohydrates.Name = "numUD_Carvohydrates";
            this.numUD_Carvohydrates.Size = new System.Drawing.Size(150, 20);
            this.numUD_Carvohydrates.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Protein";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Carbohydrates";
            // 
            // btn_Count
            // 
            this.btn_Count.Location = new System.Drawing.Point(12, 257);
            this.btn_Count.Name = "btn_Count";
            this.btn_Count.Size = new System.Drawing.Size(75, 97);
            this.btn_Count.TabIndex = 8;
            this.btn_Count.Text = "Caunt";
            this.btn_Count.UseVisualStyleBackColor = true;
            this.btn_Count.Click += new System.EventHandler(this.btn_Count_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(130, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "=";
            // 
            // lbl_Answer
            // 
            this.lbl_Answer.AutoSize = true;
            this.lbl_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Answer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Answer.Location = new System.Drawing.Point(168, 193);
            this.lbl_Answer.Name = "lbl_Answer";
            this.lbl_Answer.Size = new System.Drawing.Size(123, 33);
            this.lbl_Answer.TabIndex = 10;
            this.lbl_Answer.Text = "Calories";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(322, 366);
            this.Controls.Add(this.lbl_Answer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUD_Carvohydrates);
            this.Controls.Add(this.numUD_Fat);
            this.Controls.Add(this.numUD_Protein);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Protein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Fat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Carvohydrates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_btn_Close;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_btn_about;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUD_Carvohydrates;
        private System.Windows.Forms.NumericUpDown numUD_Fat;
        private System.Windows.Forms.NumericUpDown numUD_Protein;
        private System.Windows.Forms.Label lbl_Answer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Count;
    }
}