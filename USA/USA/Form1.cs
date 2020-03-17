﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USA
{
    public partial class Form1 : Form
    {
        DateTime time = new DateTime();
        PaintScreen screen;
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            File_tb.Text = Properties.Files.Twitts;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (File_tb.Text == "")
                return;
            Program.Start(File_tb.Text);
            timer1.Enabled = true;
        }        

        private void PictureBox1_Layout(object sender, LayoutEventArgs e)
        {
            screen = new PaintScreen(pictureBox1);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            time = time.AddMilliseconds(timer1.Interval);
            Twitts_tb.Text = Program.GetCountOfRightTwitts().ToString();
            Program.DrowCountry(screen);
        }

        
    }
}