namespace PSA
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Read = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Mod = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Takt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.PageVirt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Download = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nru_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.sh_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.R,
            this.M,
            this.Read,
            this.Mod,
            this.Time,
            this.Takt});
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(984, 596);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // Index
            // 
            this.Index.HeaderText = "№";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Width = 35;
            // 
            // R
            // 
            this.R.HeaderText = "R";
            this.R.MinimumWidth = 6;
            this.R.Name = "R";
            this.R.ReadOnly = true;
            this.R.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.R.Width = 125;
            // 
            // M
            // 
            this.M.HeaderText = "M";
            this.M.MinimumWidth = 6;
            this.M.Name = "M";
            this.M.ReadOnly = true;
            this.M.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.M.Width = 125;
            // 
            // Read
            // 
            this.Read.HeaderText = "Чтение";
            this.Read.MinimumWidth = 6;
            this.Read.Name = "Read";
            this.Read.ReadOnly = true;
            this.Read.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Read.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Read.Text = "Прочесть";
            this.Read.UseColumnTextForButtonValue = true;
            this.Read.Width = 125;
            // 
            // Mod
            // 
            this.Mod.HeaderText = "Модификация";
            this.Mod.MinimumWidth = 6;
            this.Mod.Name = "Mod";
            this.Mod.ReadOnly = true;
            this.Mod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Mod.Text = "Модифицировать";
            this.Mod.UseColumnTextForButtonValue = true;
            this.Mod.Width = 125;
            // 
            // Time
            // 
            this.Time.HeaderText = "Время создания";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 125;
            // 
            // Takt
            // 
            this.Takt.HeaderText = "Такт";
            this.Takt.MinimumWidth = 6;
            this.Takt.Name = "Takt";
            this.Takt.ReadOnly = true;
            this.Takt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Takt.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PageVirt,
            this.Download});
            this.dataGridView2.Location = new System.Drawing.Point(1002, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(308, 596);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellClick);
            // 
            // PageVirt
            // 
            this.PageVirt.HeaderText = "№";
            this.PageVirt.MinimumWidth = 6;
            this.PageVirt.Name = "PageVirt";
            this.PageVirt.ReadOnly = true;
            this.PageVirt.Width = 125;
            // 
            // Download
            // 
            this.Download.HeaderText = "Загрузка";
            this.Download.MinimumWidth = 6;
            this.Download.Name = "Download";
            this.Download.ReadOnly = true;
            this.Download.Text = "Загрузить";
            this.Download.UseColumnTextForButtonValue = true;
            this.Download.Width = 125;
            // 
            // nru_btn
            // 
            this.nru_btn.Location = new System.Drawing.Point(13, 12);
            this.nru_btn.Name = "nru_btn";
            this.nru_btn.Size = new System.Drawing.Size(75, 23);
            this.nru_btn.TabIndex = 2;
            this.nru_btn.Text = "NRU";
            this.nru_btn.UseVisualStyleBackColor = true;
            this.nru_btn.Click += new System.EventHandler(this.Nru_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(240, 12);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // sh_btn
            // 
            this.sh_btn.Location = new System.Drawing.Point(94, 12);
            this.sh_btn.Name = "sh_btn";
            this.sh_btn.Size = new System.Drawing.Size(75, 23);
            this.sh_btn.TabIndex = 4;
            this.sh_btn.Text = "SH";
            this.sh_btn.UseVisualStyleBackColor = true;
            this.sh_btn.Click += new System.EventHandler(this.Tact);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 649);
            this.Controls.Add(this.sh_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.nru_btn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button nru_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PageVirt;
        private System.Windows.Forms.DataGridViewButtonColumn Download;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn R;
        private System.Windows.Forms.DataGridViewTextBoxColumn M;
        private System.Windows.Forms.DataGridViewButtonColumn Read;
        private System.Windows.Forms.DataGridViewButtonColumn Mod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Takt;
        private System.Windows.Forms.Button sh_btn;
        private System.Windows.Forms.Timer timer1;
    }
}

