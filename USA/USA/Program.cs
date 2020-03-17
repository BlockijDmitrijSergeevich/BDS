
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USA
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        static Thread MyThread1 { set; get; }
        static Thread MyThread2 { set; get; }
        static List<Twitt> Twitts { set; get; }
        static Dictionary<string, float> Badwords { set; get; }
        static United United { set; get; }
        static string[] Stwitts { set; get; }
        static bool StopTreads { set; get; }
        private static void CreateStates()
        {
            for (int i = 0; !StopTreads && i < Stwitts.Length; i++)
            {
                while (i > Twitts.Count - 2 && Twitts.Count != Stwitts.Length) ;
                United.TwittLoc(Twitts[i]);
            }
            MessageBox.Show(Properties.Resources.FinishGood);
        }
        private static void CreateTwitts()
        {
            for (int i = 0; !StopTreads && i < Stwitts.Length; i++)
            {
                Twitts.Add(new Twitt(Stwitts[i], Badwords));
            }
        }
        public static void Start(string path)
        {
            try
            {
                Badwords = new Dictionary<string, float>();
                Twitts = new List<Twitt>();
                string statesFile = IOF.ReadFile(Properties.Files.District);
                string[] statesCoords = statesFile.Split(new char[] { '\"', '{', '}', ':' }, StringSplitOptions.RemoveEmptyEntries);
                State[] states = new State[statesCoords.Length / 2];
                for (int i = 0; i < statesCoords.Length / 2; i++)
                {
                    states[i] = new State(statesCoords[i * 2], statesCoords[i * 2 + 1]);
                }
                United = new United(states);
                string allPath = IOF.ReadFile(path);
                Stwitts = allPath.Split(new char[] { '\r', '\n' });
                string w = IOF.ReadFile(Properties.Files.Vocabluary);
                string[] sw = w.Split(new char[] { '\n', ',' });
                for (int i = 0; i < sw.Length - 1; i += 2)
                {
                    Badwords.Add(sw[i], float.Parse(sw[i + 1]));
                }
                MyThread1 = new Thread(new ThreadStart(CreateTwitts));
                MyThread1.Start();
                MyThread2 = new Thread(new ThreadStart(CreateStates));
                MyThread2.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error);
            }

        }
        public static void DrowCountry(PaintScreen screen)
        {
            screen.Clear();
            foreach (var s in United.States)
            {
                foreach (var d in s.Districts)
                {
                    screen.DrawFillArray(d.Points, s.Happy);
                }
            }
            screen.Update();
        }
        public static int GetCountOfRightTwitts()
        {
            return Twitts.Count;
        }
    }
}