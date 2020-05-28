using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Matrix
{
    public class IOF
    {
        public int[] MyStrA { get; set; }
        public int[] MyStrB { get; set; }
        private string[] ReadFileRes { get; set; }
        private string Path { get; set; }
        public IOF(string path)
        {
            this.Path = path;
            this.ReadFileRes = ReadFile();
            SplitFile();
        }
        private string[] ReadFile()
        {
            return File.ReadAllLines(Path);
        }
        private void SplitFile()
        {
            String[] nums = ReadFileRes[0].Split(new char[] { ' ' });
            String[] AS = ReadFileRes[1].Split(new char[] { ' ' });
            String[] BS = ReadFileRes[2].Split(new char[] { ' ' });
            int n = int.Parse(nums[0]);
            int m = int.Parse(nums[0]);
            MyStrA = new int[n];
            MyStrB = new int[m];
            for (int i = 0; i < n; i++)
            {
                MyStrA[i] = int.Parse(AS[i]);
            }
            for (int i = 0; i < m; i++)
            {
                MyStrB[i] = int.Parse(BS[i]);
            }
        }
    }
}
