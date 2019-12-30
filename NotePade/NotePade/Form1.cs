using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotePade.Presenters;
using NotePade.View;

namespace NotePade
{

    public partial class Form1 : Form, IPage
    {
        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        Timer timer;

        public Form1()
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            } 
            InitializeComponent();

            textBox.ScrollBars = ScrollBars.Vertical;

            infoLabel = new ToolStripLabel();
            infoLabel.Text = Resource.DateTime;
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();

            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);

            timer = new Timer() { Interval = 1000 };
            timer.Tick += Timer1_Tick;
            timer.Start();

            fontToolStripMenuItem.Click += FontToolStripMenuItem_Click;
            // добавляем возможность выбора цвета шрифта
            fontDialog1.ShowColor = true;
            // установка начального цвета для colorDialog
            colorDialog1.Color = this.BackColor;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }
        public string PContent
        {
            get
            {
                return textBox.Text;
            }
            set
            {
                textBox.Text = value;
            }
        }
        public void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saved();
            PagePresenter presenter = new PagePresenter(this);
            presenter.CalculateArea();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saved();
            this.Close();
        }

        private void NewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        public void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saved();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = File.ReadAllText(filename);
            textBox.Text = fileText;
        }

        private void CalculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.Show();
        }
        //Save text
        void saveFile(string chto, string gde)
        {
            if (chto.Count() >= 1)
            {
                if (File.Exists(gde))
                    File.Create(gde).Close();
                File.WriteAllText(gde, chto);
            }
            else
            {
                MessageBox.Show(this, Resource.LaclkText, Resource.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(textBox.Text);
                streamWriter.Close();
            }
        }

        //Вопрос сохранения файла
        private void Saved()
        {
            if (MessageBox.Show( Resource.SaveChangesFile, Resource.FileSave,
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                saveFile(textBox.Text, Resource.NewDocument);
            }
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile(textBox.Text, Resource.NewDocument);
        }

        //Copy text
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox.SelectionLength > 0)
                    textBox.Copy();
            }
            catch (System.Runtime.InteropServices.ExternalException)
            {
                MessageBox.Show(this, Resource.BufferError,
                    Resource.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Cut text
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox.SelectedText != "")
                textBox.Cut();
        }
        //Pust text
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                if (textBox.SelectionLength > 0)
                {
                    if (MessageBox.Show(Resource.Past, Resource.InsertionSelection, MessageBoxButtons.YesNo) == DialogResult.No)
                        textBox.SelectionStart = textBox.SelectionStart + textBox.SelectionLength;
                }
                textBox.Paste();
            }
        }

        public string pass1 = "hgh2g12121#$21gh323232fQ++po--";
        public string pass2 = "Qe5$%eyf65r5r5ry)))9887+--";
        public string metod = "SHA1";
        public int pass_interation = 16;
        public string initial_vector = "Qsd23Mkjk7898*hj";
        public int keySize = 256;
        private void EncryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Resource.EncryptFile, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = openFileDialog1.FileName;
                // читаем файл в строку
                string fileText = File.ReadAllText(filename);
                CryptographyAes.Cryptography.AesEnCryptography(fileText, pass1, pass2, metod, pass_interation, initial_vector, keySize);                
                if (MessageBox.Show(Resource.DeleteFile, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    File.Delete(filename);
            }
        }
        private void DecryptFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Resource.SelectFile, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = openFileDialog1.FileName;
                // читаем файл в строку
                string fileText = File.ReadAllText(filename);
                string resTextEncrypt = CryptographyAes.Cryptography.AesDeCryptography(fileText, pass1, pass2, metod, pass_interation, initial_vector, keySize);
                textBox.Text = resTextEncrypt;
            }
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            textBox.Font = fontDialog1.Font;
            textBox.ForeColor = fontDialog1.Color;
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            textBox.BackColor = colorDialog1.Color;
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.saveUpLang += LanguageUpdated;
            settingsForm.Show();
        }

        private void LanguageUpdated(object sender, EventArgs e)
        {
            this.Controls.Clear();
            WindowState = FormWindowState.Normal;
            InitializeComponent();

        }

        private void DarkeThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.White;
            this.BackColor = Color.FromArgb(38, 38, 36);
            this.statusStrip1.BackColor = Color.FromArgb(38, 38, 36);
            this.menuStrip1.ForeColor = Color.White;
            this.menuStrip1.BackColor = Color.FromArgb(38, 38, 36);
            this.textBox.BackColor = Color.FromArgb(38, 38, 36);
        }
    }
}