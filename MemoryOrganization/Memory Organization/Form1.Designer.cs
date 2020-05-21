namespace Memory_Organization
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.segment_groupBox = new System.Windows.Forms.GroupBox();
            this.addSegment_btn = new System.Windows.Forms.Button();
            this.segmentSize32_rb = new System.Windows.Forms.RadioButton();
            this.segmentSize16_rb = new System.Windows.Forms.RadioButton();
            this.segmentSize8_rb = new System.Windows.Forms.RadioButton();
            this.segmentSize4_rb = new System.Windows.Forms.RadioButton();
            this.segmentSize2_rb = new System.Windows.Forms.RadioButton();
            this.capacity_groupBox = new System.Windows.Forms.GroupBox();
            this.capacitySize512_gb = new System.Windows.Forms.RadioButton();
            this.capacity_btn = new System.Windows.Forms.Button();
            this.capacitySize256_gb = new System.Windows.Forms.RadioButton();
            this.capacitySize128_gb = new System.Windows.Forms.RadioButton();
            this.capacitySize64_gb = new System.Windows.Forms.RadioButton();
            this.capacitySize32_gb = new System.Windows.Forms.RadioButton();
            this.capacitySize16_gb = new System.Windows.Forms.RadioButton();
            this.task_groupBox = new System.Windows.Forms.GroupBox();
            this.addTask_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.taskSize_numUpDown = new System.Windows.Forms.NumericUpDown();
            this.ChangeGroup = new System.Windows.Forms.GroupBox();
            this.CopyByteButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FromNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ToNumeric = new System.Windows.Forms.NumericUpDown();
            this.RemoveTaskButton = new System.Windows.Forms.Button();
            this.NodeList = new System.Windows.Forms.ListBox();
            this.TaskList = new System.Windows.Forms.ListBox();
            this.dump_lbl = new System.Windows.Forms.Label();
            this.segment_groupBox.SuspendLayout();
            this.capacity_groupBox.SuspendLayout();
            this.task_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskSize_numUpDown)).BeginInit();
            this.ChangeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FromNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 34);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(895, 578);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // segment_groupBox
            // 
            this.segment_groupBox.Controls.Add(this.addSegment_btn);
            this.segment_groupBox.Controls.Add(this.segmentSize32_rb);
            this.segment_groupBox.Controls.Add(this.segmentSize16_rb);
            this.segment_groupBox.Controls.Add(this.segmentSize8_rb);
            this.segment_groupBox.Controls.Add(this.segmentSize4_rb);
            this.segment_groupBox.Controls.Add(this.segmentSize2_rb);
            this.segment_groupBox.Location = new System.Drawing.Point(913, 12);
            this.segment_groupBox.Name = "segment_groupBox";
            this.segment_groupBox.Size = new System.Drawing.Size(167, 200);
            this.segment_groupBox.TabIndex = 1;
            this.segment_groupBox.TabStop = false;
            this.segment_groupBox.Text = "Сегмент";
            // 
            // addSegment_btn
            // 
            this.addSegment_btn.Location = new System.Drawing.Point(7, 171);
            this.addSegment_btn.Name = "addSegment_btn";
            this.addSegment_btn.Size = new System.Drawing.Size(75, 23);
            this.addSegment_btn.TabIndex = 5;
            this.addSegment_btn.Text = "Добавить";
            this.addSegment_btn.UseVisualStyleBackColor = true;
            this.addSegment_btn.Click += new System.EventHandler(this.AddSegment_btn_Click);
            // 
            // segmentSize32_rb
            // 
            this.segmentSize32_rb.AutoSize = true;
            this.segmentSize32_rb.Location = new System.Drawing.Point(7, 130);
            this.segmentSize32_rb.Name = "segmentSize32_rb";
            this.segmentSize32_rb.Size = new System.Drawing.Size(83, 21);
            this.segmentSize32_rb.TabIndex = 4;
            this.segmentSize32_rb.TabStop = true;
            this.segmentSize32_rb.Text = "32 bytes";
            this.segmentSize32_rb.UseVisualStyleBackColor = true;
            // 
            // segmentSize16_rb
            // 
            this.segmentSize16_rb.AutoSize = true;
            this.segmentSize16_rb.Location = new System.Drawing.Point(7, 103);
            this.segmentSize16_rb.Name = "segmentSize16_rb";
            this.segmentSize16_rb.Size = new System.Drawing.Size(83, 21);
            this.segmentSize16_rb.TabIndex = 3;
            this.segmentSize16_rb.TabStop = true;
            this.segmentSize16_rb.Text = "16 bytes";
            this.segmentSize16_rb.UseVisualStyleBackColor = true;
            // 
            // segmentSize8_rb
            // 
            this.segmentSize8_rb.AutoSize = true;
            this.segmentSize8_rb.Location = new System.Drawing.Point(7, 76);
            this.segmentSize8_rb.Name = "segmentSize8_rb";
            this.segmentSize8_rb.Size = new System.Drawing.Size(75, 21);
            this.segmentSize8_rb.TabIndex = 2;
            this.segmentSize8_rb.TabStop = true;
            this.segmentSize8_rb.Text = "8 bytes";
            this.segmentSize8_rb.UseVisualStyleBackColor = true;
            // 
            // segmentSize4_rb
            // 
            this.segmentSize4_rb.AutoSize = true;
            this.segmentSize4_rb.Location = new System.Drawing.Point(7, 49);
            this.segmentSize4_rb.Name = "segmentSize4_rb";
            this.segmentSize4_rb.Size = new System.Drawing.Size(75, 21);
            this.segmentSize4_rb.TabIndex = 1;
            this.segmentSize4_rb.TabStop = true;
            this.segmentSize4_rb.Text = "4 bytes";
            this.segmentSize4_rb.UseVisualStyleBackColor = true;
            // 
            // segmentSize2_rb
            // 
            this.segmentSize2_rb.AutoSize = true;
            this.segmentSize2_rb.Location = new System.Drawing.Point(7, 22);
            this.segmentSize2_rb.Name = "segmentSize2_rb";
            this.segmentSize2_rb.Size = new System.Drawing.Size(75, 21);
            this.segmentSize2_rb.TabIndex = 0;
            this.segmentSize2_rb.TabStop = true;
            this.segmentSize2_rb.Text = "2 bytes";
            this.segmentSize2_rb.UseVisualStyleBackColor = true;
            // 
            // capacity_groupBox
            // 
            this.capacity_groupBox.Controls.Add(this.capacitySize512_gb);
            this.capacity_groupBox.Controls.Add(this.capacity_btn);
            this.capacity_groupBox.Controls.Add(this.capacitySize256_gb);
            this.capacity_groupBox.Controls.Add(this.capacitySize128_gb);
            this.capacity_groupBox.Controls.Add(this.capacitySize64_gb);
            this.capacity_groupBox.Controls.Add(this.capacitySize32_gb);
            this.capacity_groupBox.Controls.Add(this.capacitySize16_gb);
            this.capacity_groupBox.Location = new System.Drawing.Point(913, 218);
            this.capacity_groupBox.Name = "capacity_groupBox";
            this.capacity_groupBox.Size = new System.Drawing.Size(167, 219);
            this.capacity_groupBox.TabIndex = 6;
            this.capacity_groupBox.TabStop = false;
            this.capacity_groupBox.Text = "Вместимость";
            // 
            // capacitySize512_gb
            // 
            this.capacitySize512_gb.AutoSize = true;
            this.capacitySize512_gb.Location = new System.Drawing.Point(6, 157);
            this.capacitySize512_gb.Name = "capacitySize512_gb";
            this.capacitySize512_gb.Size = new System.Drawing.Size(74, 21);
            this.capacitySize512_gb.TabIndex = 6;
            this.capacitySize512_gb.TabStop = true;
            this.capacitySize512_gb.Text = "512 Kb";
            this.capacitySize512_gb.UseVisualStyleBackColor = true;
            // 
            // capacity_btn
            // 
            this.capacity_btn.Location = new System.Drawing.Point(6, 184);
            this.capacity_btn.Name = "capacity_btn";
            this.capacity_btn.Size = new System.Drawing.Size(75, 23);
            this.capacity_btn.TabIndex = 5;
            this.capacity_btn.Text = "Выделить";
            this.capacity_btn.UseVisualStyleBackColor = true;
            this.capacity_btn.Click += new System.EventHandler(this.Capacity_btn_Click);
            // 
            // capacitySize256_gb
            // 
            this.capacitySize256_gb.AutoSize = true;
            this.capacitySize256_gb.Location = new System.Drawing.Point(7, 130);
            this.capacitySize256_gb.Name = "capacitySize256_gb";
            this.capacitySize256_gb.Size = new System.Drawing.Size(74, 21);
            this.capacitySize256_gb.TabIndex = 4;
            this.capacitySize256_gb.TabStop = true;
            this.capacitySize256_gb.Text = "256 Kb";
            this.capacitySize256_gb.UseVisualStyleBackColor = true;
            // 
            // capacitySize128_gb
            // 
            this.capacitySize128_gb.AutoSize = true;
            this.capacitySize128_gb.Location = new System.Drawing.Point(7, 103);
            this.capacitySize128_gb.Name = "capacitySize128_gb";
            this.capacitySize128_gb.Size = new System.Drawing.Size(78, 21);
            this.capacitySize128_gb.TabIndex = 3;
            this.capacitySize128_gb.TabStop = true;
            this.capacitySize128_gb.Text = "128  Kb";
            this.capacitySize128_gb.UseVisualStyleBackColor = true;
            // 
            // capacitySize64_gb
            // 
            this.capacitySize64_gb.AutoSize = true;
            this.capacitySize64_gb.Location = new System.Drawing.Point(7, 76);
            this.capacitySize64_gb.Name = "capacitySize64_gb";
            this.capacitySize64_gb.Size = new System.Drawing.Size(66, 21);
            this.capacitySize64_gb.TabIndex = 2;
            this.capacitySize64_gb.TabStop = true;
            this.capacitySize64_gb.Text = "64 Kb";
            this.capacitySize64_gb.UseVisualStyleBackColor = true;
            // 
            // capacitySize32_gb
            // 
            this.capacitySize32_gb.AutoSize = true;
            this.capacitySize32_gb.Location = new System.Drawing.Point(7, 49);
            this.capacitySize32_gb.Name = "capacitySize32_gb";
            this.capacitySize32_gb.Size = new System.Drawing.Size(66, 21);
            this.capacitySize32_gb.TabIndex = 1;
            this.capacitySize32_gb.TabStop = true;
            this.capacitySize32_gb.Text = "32 Kb";
            this.capacitySize32_gb.UseVisualStyleBackColor = true;
            // 
            // capacitySize16_gb
            // 
            this.capacitySize16_gb.AutoSize = true;
            this.capacitySize16_gb.Location = new System.Drawing.Point(7, 22);
            this.capacitySize16_gb.Name = "capacitySize16_gb";
            this.capacitySize16_gb.Size = new System.Drawing.Size(66, 21);
            this.capacitySize16_gb.TabIndex = 0;
            this.capacitySize16_gb.TabStop = true;
            this.capacitySize16_gb.Text = "16 Kb";
            this.capacitySize16_gb.UseVisualStyleBackColor = true;
            // 
            // task_groupBox
            // 
            this.task_groupBox.Controls.Add(this.addTask_btn);
            this.task_groupBox.Controls.Add(this.label1);
            this.task_groupBox.Controls.Add(this.taskSize_numUpDown);
            this.task_groupBox.Location = new System.Drawing.Point(913, 444);
            this.task_groupBox.Name = "task_groupBox";
            this.task_groupBox.Size = new System.Drawing.Size(167, 167);
            this.task_groupBox.TabIndex = 7;
            this.task_groupBox.TabStop = false;
            this.task_groupBox.Text = "Задача";
            // 
            // addTask_btn
            // 
            this.addTask_btn.Location = new System.Drawing.Point(7, 138);
            this.addTask_btn.Name = "addTask_btn";
            this.addTask_btn.Size = new System.Drawing.Size(75, 23);
            this.addTask_btn.TabIndex = 2;
            this.addTask_btn.Text = "Добавить";
            this.addTask_btn.UseVisualStyleBackColor = true;
            this.addTask_btn.Click += new System.EventHandler(this.AddTask_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kb";
            // 
            // taskSize_numUpDown
            // 
            this.taskSize_numUpDown.Location = new System.Drawing.Point(7, 22);
            this.taskSize_numUpDown.Name = "taskSize_numUpDown";
            this.taskSize_numUpDown.Size = new System.Drawing.Size(120, 22);
            this.taskSize_numUpDown.TabIndex = 0;
            // 
            // ChangeGroup
            // 
            this.ChangeGroup.Controls.Add(this.CopyByteButton);
            this.ChangeGroup.Controls.Add(this.label3);
            this.ChangeGroup.Controls.Add(this.FromNumeric);
            this.ChangeGroup.Controls.Add(this.label2);
            this.ChangeGroup.Controls.Add(this.ToNumeric);
            this.ChangeGroup.Enabled = false;
            this.ChangeGroup.Location = new System.Drawing.Point(1087, 267);
            this.ChangeGroup.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeGroup.Name = "ChangeGroup";
            this.ChangeGroup.Padding = new System.Windows.Forms.Padding(4);
            this.ChangeGroup.Size = new System.Drawing.Size(278, 129);
            this.ChangeGroup.TabIndex = 16;
            this.ChangeGroup.TabStop = false;
            this.ChangeGroup.Text = "Изменение";
            // 
            // CopyByteButton
            // 
            this.CopyByteButton.Location = new System.Drawing.Point(7, 91);
            this.CopyByteButton.Margin = new System.Windows.Forms.Padding(4);
            this.CopyByteButton.Name = "CopyByteButton";
            this.CopyByteButton.Size = new System.Drawing.Size(147, 28);
            this.CopyByteButton.TabIndex = 7;
            this.CopyByteButton.Text = "CopyByte";
            this.CopyByteButton.UseVisualStyleBackColor = true;
            this.CopyByteButton.Click += new System.EventHandler(this.CopyByteButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "В";
            // 
            // FromNumeric
            // 
            this.FromNumeric.Location = new System.Drawing.Point(7, 26);
            this.FromNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.FromNumeric.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.FromNumeric.Name = "FromNumeric";
            this.FromNumeric.Size = new System.Drawing.Size(105, 22);
            this.FromNumeric.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Из";
            // 
            // ToNumeric
            // 
            this.ToNumeric.Location = new System.Drawing.Point(8, 53);
            this.ToNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.ToNumeric.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.ToNumeric.Name = "ToNumeric";
            this.ToNumeric.Size = new System.Drawing.Size(104, 22);
            this.ToNumeric.TabIndex = 9;
            // 
            // RemoveTaskButton
            // 
            this.RemoveTaskButton.Enabled = false;
            this.RemoveTaskButton.Location = new System.Drawing.Point(1087, 225);
            this.RemoveTaskButton.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveTaskButton.Name = "RemoveTaskButton";
            this.RemoveTaskButton.Size = new System.Drawing.Size(279, 28);
            this.RemoveTaskButton.TabIndex = 13;
            this.RemoveTaskButton.Text = "Удалить задачу";
            this.RemoveTaskButton.UseVisualStyleBackColor = true;
            this.RemoveTaskButton.Click += new System.EventHandler(this.RemoveTaskButton_Click);
            // 
            // NodeList
            // 
            this.NodeList.FormattingEnabled = true;
            this.NodeList.ItemHeight = 16;
            this.NodeList.Location = new System.Drawing.Point(1087, 394);
            this.NodeList.Margin = new System.Windows.Forms.Padding(4);
            this.NodeList.Name = "NodeList";
            this.NodeList.Size = new System.Drawing.Size(279, 212);
            this.NodeList.TabIndex = 15;
            // 
            // TaskList
            // 
            this.TaskList.FormattingEnabled = true;
            this.TaskList.ItemHeight = 16;
            this.TaskList.Location = new System.Drawing.Point(1087, 16);
            this.TaskList.Margin = new System.Windows.Forms.Padding(4);
            this.TaskList.Name = "TaskList";
            this.TaskList.Size = new System.Drawing.Size(278, 196);
            this.TaskList.TabIndex = 14;
            this.TaskList.SelectedIndexChanged += new System.EventHandler(this.TaskList_SelectedIndexChanged);
            // 
            // dump_lbl
            // 
            this.dump_lbl.AutoSize = true;
            this.dump_lbl.Location = new System.Drawing.Point(13, 12);
            this.dump_lbl.Name = "dump_lbl";
            this.dump_lbl.Size = new System.Drawing.Size(99, 17);
            this.dump_lbl.TabIndex = 17;
            this.dump_lbl.Text = "Memory Dump";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 625);
            this.Controls.Add(this.dump_lbl);
            this.Controls.Add(this.ChangeGroup);
            this.Controls.Add(this.RemoveTaskButton);
            this.Controls.Add(this.NodeList);
            this.Controls.Add(this.TaskList);
            this.Controls.Add(this.task_groupBox);
            this.Controls.Add(this.capacity_groupBox);
            this.Controls.Add(this.segment_groupBox);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.segment_groupBox.ResumeLayout(false);
            this.segment_groupBox.PerformLayout();
            this.capacity_groupBox.ResumeLayout(false);
            this.capacity_groupBox.PerformLayout();
            this.task_groupBox.ResumeLayout(false);
            this.task_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskSize_numUpDown)).EndInit();
            this.ChangeGroup.ResumeLayout(false);
            this.ChangeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FromNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox segment_groupBox;
        private System.Windows.Forms.Button addSegment_btn;
        private System.Windows.Forms.RadioButton segmentSize32_rb;
        private System.Windows.Forms.RadioButton segmentSize16_rb;
        private System.Windows.Forms.RadioButton segmentSize8_rb;
        private System.Windows.Forms.RadioButton segmentSize4_rb;
        private System.Windows.Forms.RadioButton segmentSize2_rb;
        private System.Windows.Forms.GroupBox capacity_groupBox;
        private System.Windows.Forms.RadioButton capacitySize512_gb;
        private System.Windows.Forms.Button capacity_btn;
        private System.Windows.Forms.RadioButton capacitySize256_gb;
        private System.Windows.Forms.RadioButton capacitySize128_gb;
        private System.Windows.Forms.RadioButton capacitySize64_gb;
        private System.Windows.Forms.RadioButton capacitySize32_gb;
        private System.Windows.Forms.RadioButton capacitySize16_gb;
        private System.Windows.Forms.GroupBox task_groupBox;
        private System.Windows.Forms.Button addTask_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown taskSize_numUpDown;
        private System.Windows.Forms.GroupBox ChangeGroup;
        private System.Windows.Forms.Button CopyByteButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown FromNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ToNumeric;
        private System.Windows.Forms.Button RemoveTaskButton;
        private System.Windows.Forms.ListBox NodeList;
        private System.Windows.Forms.ListBox TaskList;
        private System.Windows.Forms.Label dump_lbl;
    }
}

