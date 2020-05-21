namespace Fit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Завтрак", 0, 0);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Обед", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Ужин", 2, 2);
            this.saveDiet_btn = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.squirrels_tb = new System.Windows.Forms.TextBox();
            this.calories_tb = new System.Windows.Forms.TextBox();
            this.carbohydrates_tb = new System.Windows.Forms.TextBox();
            this.fats_tb = new System.Windows.Forms.TextBox();
            this.weightGramm_lbl = new System.Windows.Forms.TextBox();
            this.weight_lbl = new System.Windows.Forms.Label();
            this.calories_lbl = new System.Windows.Forms.Label();
            this.carbohydrates_lbl = new System.Windows.Forms.Label();
            this.fats_lbl = new System.Windows.Forms.Label();
            this.squirrels_lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clearDiet_btn = new System.Windows.Forms.Button();
            this.calculate_btn = new System.Windows.Forms.Button();
            this.norm_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.activityLow_radioBtn = new System.Windows.Forms.RadioButton();
            this.activityModerate_radioBtn = new System.Windows.Forms.RadioButton();
            this.activityHigth_radioBtn = new System.Windows.Forms.RadioButton();
            this.activityAverage_radioBtn = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.searchOk_btn = new System.Windows.Forms.Button();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.removeProduct_btn = new System.Windows.Forms.Button();
            this.removeCategory_btn = new System.Windows.Forms.Button();
            this.addProduct_btn = new System.Windows.Forms.Button();
            this.addCategory_btn = new System.Windows.Forms.Button();
            this.weight_tb = new System.Windows.Forms.TextBox();
            this.heigt_tb = new System.Windows.Forms.TextBox();
            this.age_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveDiet_btn
            // 
            this.saveDiet_btn.Location = new System.Drawing.Point(1265, 74);
            this.saveDiet_btn.Name = "saveDiet_btn";
            this.saveDiet_btn.Size = new System.Drawing.Size(144, 42);
            this.saveDiet_btn.TabIndex = 83;
            this.saveDiet_btn.Text = "Сохранить \r\nрацион\r\n";
            this.saveDiet_btn.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Location = new System.Drawing.Point(1388, 484);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(113, 22);
            this.textBox12.TabIndex = 82;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1207, 484);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 17);
            this.label14.TabIndex = 81;
            this.label14.Text = "Калорийность рациона";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1207, 507);
            this.progressBar1.Maximum = 3000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(294, 41);
            this.progressBar1.TabIndex = 80;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(1229, 395);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(254, 56);
            this.trackBar1.TabIndex = 79;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 100;
            // 
            // squirrels_tb
            // 
            this.squirrels_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.squirrels_tb.Location = new System.Drawing.Point(1312, 193);
            this.squirrels_tb.Name = "squirrels_tb";
            this.squirrels_tb.ReadOnly = true;
            this.squirrels_tb.Size = new System.Drawing.Size(137, 15);
            this.squirrels_tb.TabIndex = 78;
            // 
            // calories_tb
            // 
            this.calories_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calories_tb.Location = new System.Drawing.Point(1312, 316);
            this.calories_tb.Name = "calories_tb";
            this.calories_tb.ReadOnly = true;
            this.calories_tb.Size = new System.Drawing.Size(137, 15);
            this.calories_tb.TabIndex = 76;
            // 
            // carbohydrates_tb
            // 
            this.carbohydrates_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.carbohydrates_tb.Location = new System.Drawing.Point(1312, 274);
            this.carbohydrates_tb.Name = "carbohydrates_tb";
            this.carbohydrates_tb.ReadOnly = true;
            this.carbohydrates_tb.Size = new System.Drawing.Size(137, 15);
            this.carbohydrates_tb.TabIndex = 75;
            // 
            // fats_tb
            // 
            this.fats_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fats_tb.Location = new System.Drawing.Point(1312, 233);
            this.fats_tb.Name = "fats_tb";
            this.fats_tb.ReadOnly = true;
            this.fats_tb.Size = new System.Drawing.Size(137, 15);
            this.fats_tb.TabIndex = 74;
            // 
            // weightGramm_lbl
            // 
            this.weightGramm_lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.weightGramm_lbl.Location = new System.Drawing.Point(1312, 356);
            this.weightGramm_lbl.Name = "weightGramm_lbl";
            this.weightGramm_lbl.ReadOnly = true;
            this.weightGramm_lbl.Size = new System.Drawing.Size(137, 15);
            this.weightGramm_lbl.TabIndex = 77;
            // 
            // weight_lbl
            // 
            this.weight_lbl.AutoSize = true;
            this.weight_lbl.Location = new System.Drawing.Point(1204, 356);
            this.weight_lbl.Name = "weight_lbl";
            this.weight_lbl.Size = new System.Drawing.Size(74, 17);
            this.weight_lbl.TabIndex = 73;
            this.weight_lbl.Text = "Вес, г / мл";
            // 
            // calories_lbl
            // 
            this.calories_lbl.AutoSize = true;
            this.calories_lbl.Location = new System.Drawing.Point(1204, 316);
            this.calories_lbl.Name = "calories_lbl";
            this.calories_lbl.Size = new System.Drawing.Size(65, 17);
            this.calories_lbl.TabIndex = 72;
            this.calories_lbl.Text = "Калории";
            // 
            // carbohydrates_lbl
            // 
            this.carbohydrates_lbl.AutoSize = true;
            this.carbohydrates_lbl.Location = new System.Drawing.Point(1204, 274);
            this.carbohydrates_lbl.Name = "carbohydrates_lbl";
            this.carbohydrates_lbl.Size = new System.Drawing.Size(71, 17);
            this.carbohydrates_lbl.TabIndex = 71;
            this.carbohydrates_lbl.Text = "Углеводы";
            // 
            // fats_lbl
            // 
            this.fats_lbl.AutoSize = true;
            this.fats_lbl.Location = new System.Drawing.Point(1204, 233);
            this.fats_lbl.Name = "fats_lbl";
            this.fats_lbl.Size = new System.Drawing.Size(47, 17);
            this.fats_lbl.TabIndex = 70;
            this.fats_lbl.Text = "Жиры";
            // 
            // squirrels_lbl
            // 
            this.squirrels_lbl.AutoSize = true;
            this.squirrels_lbl.Location = new System.Drawing.Point(1204, 193);
            this.squirrels_lbl.Name = "squirrels_lbl";
            this.squirrels_lbl.Size = new System.Drawing.Size(48, 17);
            this.squirrels_lbl.TabIndex = 69;
            this.squirrels_lbl.Text = "Белки";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(1204, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 17);
            this.label8.TabIndex = 68;
            this.label8.Text = "Продукт не выбран";
            // 
            // clearDiet_btn
            // 
            this.clearDiet_btn.Location = new System.Drawing.Point(1265, 12);
            this.clearDiet_btn.Name = "clearDiet_btn";
            this.clearDiet_btn.Size = new System.Drawing.Size(144, 42);
            this.clearDiet_btn.TabIndex = 67;
            this.clearDiet_btn.Text = "Очистить \r\nрацион\r\n";
            this.clearDiet_btn.UseVisualStyleBackColor = true;
            // 
            // calculate_btn
            // 
            this.calculate_btn.Location = new System.Drawing.Point(258, 655);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(92, 34);
            this.calculate_btn.TabIndex = 66;
            this.calculate_btn.Text = "Расчитать";
            this.calculate_btn.UseVisualStyleBackColor = true;
            // 
            // norm_tb
            // 
            this.norm_tb.Location = new System.Drawing.Point(39, 661);
            this.norm_tb.Name = "norm_tb";
            this.norm_tb.ReadOnly = true;
            this.norm_tb.Size = new System.Drawing.Size(213, 22);
            this.norm_tb.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(74, 628);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 20);
            this.label7.TabIndex = 64;
            this.label7.Text = "Дневная норма калорий";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.activityLow_radioBtn);
            this.panel1.Controls.Add(this.activityModerate_radioBtn);
            this.panel1.Controls.Add(this.activityHigth_radioBtn);
            this.panel1.Controls.Add(this.activityAverage_radioBtn);
            this.panel1.Location = new System.Drawing.Point(110, 507);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 108);
            this.panel1.TabIndex = 63;
            // 
            // activityLow_radioBtn
            // 
            this.activityLow_radioBtn.AutoSize = true;
            this.activityLow_radioBtn.Location = new System.Drawing.Point(3, 3);
            this.activityLow_radioBtn.Name = "activityLow_radioBtn";
            this.activityLow_radioBtn.Size = new System.Drawing.Size(77, 21);
            this.activityLow_radioBtn.TabIndex = 18;
            this.activityLow_radioBtn.Text = "Низкая";
            this.activityLow_radioBtn.UseVisualStyleBackColor = true;
            // 
            // activityModerate_radioBtn
            // 
            this.activityModerate_radioBtn.AutoSize = true;
            this.activityModerate_radioBtn.Location = new System.Drawing.Point(3, 30);
            this.activityModerate_radioBtn.Name = "activityModerate_radioBtn";
            this.activityModerate_radioBtn.Size = new System.Drawing.Size(103, 21);
            this.activityModerate_radioBtn.TabIndex = 19;
            this.activityModerate_radioBtn.TabStop = true;
            this.activityModerate_radioBtn.Text = "Умеренная";
            this.activityModerate_radioBtn.UseVisualStyleBackColor = true;
            // 
            // activityHigth_radioBtn
            // 
            this.activityHigth_radioBtn.AutoSize = true;
            this.activityHigth_radioBtn.Checked = true;
            this.activityHigth_radioBtn.Location = new System.Drawing.Point(3, 84);
            this.activityHigth_radioBtn.Name = "activityHigth_radioBtn";
            this.activityHigth_radioBtn.Size = new System.Drawing.Size(86, 21);
            this.activityHigth_radioBtn.TabIndex = 21;
            this.activityHigth_radioBtn.TabStop = true;
            this.activityHigth_radioBtn.Text = "Высокая";
            this.activityHigth_radioBtn.UseVisualStyleBackColor = true;
            // 
            // activityAverage_radioBtn
            // 
            this.activityAverage_radioBtn.AutoSize = true;
            this.activityAverage_radioBtn.Location = new System.Drawing.Point(3, 57);
            this.activityAverage_radioBtn.Name = "activityAverage_radioBtn";
            this.activityAverage_radioBtn.Size = new System.Drawing.Size(86, 21);
            this.activityAverage_radioBtn.TabIndex = 20;
            this.activityAverage_radioBtn.TabStop = true;
            this.activityAverage_radioBtn.Text = "Средняя";
            this.activityAverage_radioBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "Активность";
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.ImageIndex = 26;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.ItemHeight = 30;
            this.treeView1.Location = new System.Drawing.Point(403, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 26;
            this.treeView1.Size = new System.Drawing.Size(353, 706);
            this.treeView1.TabIndex = 46;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "menu.png");
            this.imageList1.Images.SetKeyName(1, "cocktail.png");
            this.imageList1.Images.SetKeyName(2, "fast-food.png");
            this.imageList1.Images.SetKeyName(3, "mushrooms.png");
            this.imageList1.Images.SetKeyName(4, "porridge.png");
            this.imageList1.Images.SetKeyName(5, "salami.png");
            this.imageList1.Images.SetKeyName(6, "compote.png");
            this.imageList1.Images.SetKeyName(7, "butter.png");
            this.imageList1.Images.SetKeyName(8, "milk.png");
            this.imageList1.Images.SetKeyName(9, "vegetables.png");
            this.imageList1.Images.SetKeyName(10, "flour.png");
            this.imageList1.Images.SetKeyName(11, "meat.png");
            this.imageList1.Images.SetKeyName(12, "carrot.png");
            this.imageList1.Images.SetKeyName(13, "nuts.png");
            this.imageList1.Images.SetKeyName(14, "lunch.png");
            this.imageList1.Images.SetKeyName(15, "fish.png");
            this.imageList1.Images.SetKeyName(16, "cupcake.png");
            this.imageList1.Images.SetKeyName(17, "juice.png");
            this.imageList1.Images.SetKeyName(18, "soup.png");
            this.imageList1.Images.SetKeyName(19, "dried-fruit.png");
            this.imageList1.Images.SetKeyName(20, "cheese.png");
            this.imageList1.Images.SetKeyName(21, "cheese1.png");
            this.imageList1.Images.SetKeyName(22, "fruits.png");
            this.imageList1.Images.SetKeyName(23, "bread.png");
            this.imageList1.Images.SetKeyName(24, "berry.png");
            this.imageList1.Images.SetKeyName(25, "eggs.png");
            this.imageList1.Images.SetKeyName(26, "search.png");
            // 
            // treeView2
            // 
            this.treeView2.AllowDrop = true;
            this.treeView2.ImageIndex = 3;
            this.treeView2.ImageList = this.imageList2;
            this.treeView2.ItemHeight = 30;
            this.treeView2.Location = new System.Drawing.Point(832, 14);
            this.treeView2.Name = "treeView2";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "Узел7";
            treeNode1.SelectedImageIndex = 0;
            treeNode1.Text = "Завтрак";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "Узел8";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Обед";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "Узел9";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Text = "Ужин";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView2.SelectedImageIndex = 0;
            this.treeView2.Size = new System.Drawing.Size(353, 704);
            this.treeView2.TabIndex = 54;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "breakfast.png");
            this.imageList2.Images.SetKeyName(1, "lunch2.png");
            this.imageList2.Images.SetKeyName(2, "dinner2.png");
            this.imageList2.Images.SetKeyName(3, "check.png");
            // 
            // searchOk_btn
            // 
            this.searchOk_btn.Location = new System.Drawing.Point(337, 184);
            this.searchOk_btn.Name = "searchOk_btn";
            this.searchOk_btn.Size = new System.Drawing.Size(60, 34);
            this.searchOk_btn.TabIndex = 53;
            this.searchOk_btn.Text = "Ок";
            this.searchOk_btn.UseVisualStyleBackColor = true;
            // 
            // search_tb
            // 
            this.search_tb.Location = new System.Drawing.Point(123, 188);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(199, 22);
            this.search_tb.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Найти продукт";
            // 
            // removeProduct_btn
            // 
            this.removeProduct_btn.Location = new System.Drawing.Point(164, 60);
            this.removeProduct_btn.Name = "removeProduct_btn";
            this.removeProduct_btn.Size = new System.Drawing.Size(144, 42);
            this.removeProduct_btn.TabIndex = 50;
            this.removeProduct_btn.Text = "Удалить \r\nпродукт\r\n";
            this.removeProduct_btn.UseVisualStyleBackColor = true;
            // 
            // removeCategory_btn
            // 
            this.removeCategory_btn.Location = new System.Drawing.Point(14, 60);
            this.removeCategory_btn.Name = "removeCategory_btn";
            this.removeCategory_btn.Size = new System.Drawing.Size(144, 42);
            this.removeCategory_btn.TabIndex = 49;
            this.removeCategory_btn.Text = "Удалить \r\nкатегорию";
            this.removeCategory_btn.UseVisualStyleBackColor = true;
            // 
            // addProduct_btn
            // 
            this.addProduct_btn.Location = new System.Drawing.Point(164, 12);
            this.addProduct_btn.Name = "addProduct_btn";
            this.addProduct_btn.Size = new System.Drawing.Size(144, 42);
            this.addProduct_btn.TabIndex = 48;
            this.addProduct_btn.Text = "Добавить \r\nпродукт";
            this.addProduct_btn.UseVisualStyleBackColor = true;
            // 
            // addCategory_btn
            // 
            this.addCategory_btn.Location = new System.Drawing.Point(14, 12);
            this.addCategory_btn.Name = "addCategory_btn";
            this.addCategory_btn.Size = new System.Drawing.Size(144, 42);
            this.addCategory_btn.TabIndex = 47;
            this.addCategory_btn.Text = "Добавить категорию\r\n";
            this.addCategory_btn.UseVisualStyleBackColor = true;
            // 
            // weight_tb
            // 
            this.weight_tb.Location = new System.Drawing.Point(110, 463);
            this.weight_tb.Name = "weight_tb";
            this.weight_tb.Size = new System.Drawing.Size(212, 22);
            this.weight_tb.TabIndex = 61;
            // 
            // heigt_tb
            // 
            this.heigt_tb.Location = new System.Drawing.Point(110, 418);
            this.heigt_tb.Name = "heigt_tb";
            this.heigt_tb.Size = new System.Drawing.Size(212, 22);
            this.heigt_tb.TabIndex = 60;
            // 
            // age_tb
            // 
            this.age_tb.Location = new System.Drawing.Point(110, 376);
            this.age_tb.Name = "age_tb";
            this.age_tb.Size = new System.Drawing.Size(212, 22);
            this.age_tb.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Вес, кг";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Рост, см";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Возраст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(124, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Пользователь";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 723);
            this.Controls.Add(this.saveDiet_btn);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.squirrels_tb);
            this.Controls.Add(this.calories_tb);
            this.Controls.Add(this.carbohydrates_tb);
            this.Controls.Add(this.fats_tb);
            this.Controls.Add(this.weightGramm_lbl);
            this.Controls.Add(this.weight_lbl);
            this.Controls.Add(this.calories_lbl);
            this.Controls.Add(this.carbohydrates_lbl);
            this.Controls.Add(this.fats_lbl);
            this.Controls.Add(this.squirrels_lbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.clearDiet_btn);
            this.Controls.Add(this.calculate_btn);
            this.Controls.Add(this.norm_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.searchOk_btn);
            this.Controls.Add(this.search_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeProduct_btn);
            this.Controls.Add(this.removeCategory_btn);
            this.Controls.Add(this.addProduct_btn);
            this.Controls.Add(this.addCategory_btn);
            this.Controls.Add(this.weight_tb);
            this.Controls.Add(this.heigt_tb);
            this.Controls.Add(this.age_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveDiet_btn;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox squirrels_tb;
        private System.Windows.Forms.TextBox calories_tb;
        private System.Windows.Forms.TextBox carbohydrates_tb;
        private System.Windows.Forms.TextBox fats_tb;
        private System.Windows.Forms.TextBox weightGramm_lbl;
        private System.Windows.Forms.Label weight_lbl;
        private System.Windows.Forms.Label calories_lbl;
        private System.Windows.Forms.Label carbohydrates_lbl;
        private System.Windows.Forms.Label fats_lbl;
        private System.Windows.Forms.Label squirrels_lbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clearDiet_btn;
        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.TextBox norm_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton activityLow_radioBtn;
        private System.Windows.Forms.RadioButton activityModerate_radioBtn;
        private System.Windows.Forms.RadioButton activityHigth_radioBtn;
        private System.Windows.Forms.RadioButton activityAverage_radioBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button searchOk_btn;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeProduct_btn;
        private System.Windows.Forms.Button removeCategory_btn;
        private System.Windows.Forms.Button addProduct_btn;
        private System.Windows.Forms.Button addCategory_btn;
        private System.Windows.Forms.TextBox weight_tb;
        private System.Windows.Forms.TextBox heigt_tb;
        private System.Windows.Forms.TextBox age_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

