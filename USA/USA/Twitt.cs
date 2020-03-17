﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace USA
{
    class Twitt
    {
        public Point Point { get; set; }
        public float Happy { get; set; }
        public string TwittText { get; set; }
        public string AllTwitt { get; set; }
        Dictionary<string, float> KeyValuePairs { get; set; }
        public Twitt(string allTwitt, Dictionary<string, float> keyValuePairs)
        {
            this.AllTwitt = allTwitt;
            this.KeyValuePairs = keyValuePairs;
            SplitText();
        }
        public void SplitText()
        {
            string[] part = AllTwitt.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
            if (part.Length < 2)
                return;
            string[] pointsS = part[0].Split(new char[] { ',', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
            Point = new Point(float.Parse(pointsS[1]), float.Parse(pointsS[0]));
            TwittText = part[3];
            string[] words = TwittText.ToLower().Split(new char[] { ',', '!', '?', ' ', '.', '\'', '\"', '#', '*', ':', ';', '(', ')', '&', '|', '\\', '/' }, StringSplitOptions.RemoveEmptyEntries);
            Happy = 0;
            int tempA = 0;
            for (int i = 0; i < 6 && i < words.Length; i++)
            {
                tempA += Search(i, words, KeyValuePairs);
            }
            if (tempA != 0) { Happy /= tempA; }
            else { Happy = float.MaxValue; }
        }
        public int Search(int number, string[] words, Dictionary<string, float> keyValuePairs)
        {
            int tempA = 0;
            string word;
            for (int i = 0; i < words.Length - number; i++)
            {
                word = words[i];
                for (int j = i + 1; j < i + number + 1; j++)
                {
                    word += ' ' + words[j];
                }
                if (keyValuePairs.ContainsKey(word))
                {
                    Happy += keyValuePairs[word];
                    tempA++;
                }
            }
            return tempA;
        }
    }
}