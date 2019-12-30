using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LR1
{
    public enum TypeOfSentence
    {
        interrogative,
        exclamatory,
        declarative
    }
    public class MyValue
    {
        public int numOfRepetitions;
        public SortedSet<int> pageNumbers = new SortedSet<int>();
    }
   /* public class MySortedDictionary : SortedDictionary<string, MyValue>
    {
        public void Add(string word, int numOfRepetitions, SortedSet<int> pageNumbers)
        {
            MyValue val = new MyValue();
            val.numOfRepetitions = numOfRepetitions;
            val.pageNumbers = pageNumbers;
            Add(word.ToLower(), val);
        }
    }*/
}
