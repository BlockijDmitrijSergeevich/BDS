using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSA
{
    public partial class Form1 : Form
    {
        Page[] page;
        List<Page> LasyPages;
        public Form1()
        {
            InitializeComponent();
            page = new Page[5];
            for (int i = 0; i < page.Length; i++)
            {
                page[i] = new Page();
            }
            LasyPages = new List<Page>();
            Fill();
        }

        private void Fill()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < page.Length; i++)
            {
                dataGridView1.Rows.Add(new object[] { page[i].Index, page[i].R, page[i].M, null, null, page[i].time.TimeOfDay, page[i].tact });
            }
            dataGridView2.Rows.Clear();
            for (int i = 0; i < LasyPages.Count; i++)
            {
                dataGridView2.Rows.Add(new object[] { LasyPages[i].Index });
            }
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Read"].Index)
            {                
                page[e.RowIndex].Read();
                Fill();
            }
            if (e.ColumnIndex == dataGridView1.Columns["Mod"].Index)
            {
                page[e.RowIndex].Mod();
                Fill();
            }
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["Download"].Index)
            {
                int lasyPage = Find();
                if (page[lasyPage].M)
                    LasyPages.Add(page[lasyPage]);
                page[lasyPage] = (LasyPages[e.RowIndex]);
                LasyPages.RemoveAt(e.RowIndex);
                Fill();
            }
        }
        private int Find()
        {
            if (nru_btn.Text == "NRU")
            {
                for (int i = 0; i < page.Length; i++)
                {
                    if (page[i].Class == 0)
                        return i;
                }
                for (int i = 0; i < page.Length; i++)
                {
                    if (page[i].Class == 1)
                        return i;
                }
                for (int i = 0; i < page.Length; i++)
                {
                    if (page[i].Class == 2)
                        return i;
                }
                return 0;
            }
            else
            {
                for (int i = 0; i < page.Length; i++)
                {
                    if (page[i].R)
                        page[i].Old();
                    else
                        return i;
                }
                return 0;
            }
        }

        private void Nru_btn_Click(object sender, EventArgs e)
        {
            switch (nru_btn.Text)
            {
                case "SH":
                    {
                        nru_btn.Text = "NRU";
                        sh_btn.Visible = true;
                        break;
                    }
                case "NRU":
                    {
                        nru_btn.Text = "SH";
                        sh_btn.Visible = false;
                        break;
                    }
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            int lasyPage = Find();
            if (page[lasyPage].M)
            {
                page[lasyPage].Old();
                page[lasyPage].Save();
                LasyPages.Add(page[lasyPage]);
            }
            page[lasyPage] = new Page();
            Fill();
        }

        private void Tact(object sender, EventArgs e)
        {

            foreach (var page in page)
            {
                page.Old();
            }
            Fill();
        }
    }
}
