using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MutualExclusion
{
    public partial class Form1 : Form
    {
        PetersonLock Peterson = new PetersonLock();
        StrictAlternation Strict = new StrictAlternation();
        public Form1()
        {
            InitializeComponent();
            Encoding win_1251 = Encoding.GetEncoding("windows-1251");
            Peterson.OnCritical += OnCritical;
            Peterson.OnNonCritical += OnNonCritical;
            Strict.OnCritical += OnCritical;
            Strict.OnNonCritical += OnNonCritical;
        }
        List<string> lines = new List<string>();
        private void OnNonCritical(object sender, LockEventArgs e)
        {
            lines.Add("Thread: " + e.ThreadID.ToString() + " on noncritical " + DateTime.Now.ToString() + " " + DateTime.Now.Millisecond.ToString());
        }

        private void OnCritical(object sender, LockEventArgs e)
        {
            lines.Add("Thread: " + e.ThreadID.ToString() + " on critical " + DateTime.Now.ToString() + " " + DateTime.Now.Millisecond.ToString());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sourceString = sourceText.Text;
            sourceNum = Convert.ToDouble(numberSource.Value);
            lines.Clear();
            Task task = Task.Run(() => StringTask(Peterson, 0));
            SquareTask(Peterson, 1);
            Task.WaitAll(task);
            resultText.Text = resultString;
            resultNum.Text = resultSquare.ToString();
            info.Lines = lines.ToArray();
        }

        private void Alternation_Click(object sender, EventArgs e)
        {
            sourceString = sourceText.Text;
            sourceNum = Convert.ToDouble(numberSource.Value);
            lines.Clear();
            Task task = Task.Run(() => StringTask(Strict, 0));
            SquareTask(Strict, 1);
            Task.WaitAll(task);
            resultText.Text = resultString;
            resultNum.Text = resultSquare.ToString();
            info.Lines = lines.ToArray();
        }
        string sourceString;
        double sourceNum;

        string resultString;
        double resultSquare;

        public void StringTask(IThreadLocker locker, int thread)
        {
            locker.Lock(thread);
            string input = sourceString;
            Regex regex = new Regex(@"\S");

            char[] arr = input.ToCharArray();            
            string result = regex.Replace(input, ((short)arr[0]).ToString());

            resultString = result;
            locker.Unlock(thread);

        }
        public void SquareTask(IThreadLocker locker, int thread)
        {
            locker.Lock(thread);
            double num = sourceNum;

            double result = num * num;

            resultSquare = result;
            locker.Unlock(thread);
        }
    }
}
