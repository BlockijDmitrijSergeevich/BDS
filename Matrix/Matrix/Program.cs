using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        public static List<Tuple<int, int>> edges = new List<Tuple<int, int>>();
        public static List<int> myList = new List<int>();
        public static IOF iOF;
        public static int[,] smejMatrix { get; set; }
        static void Main(string[] args)
        {
            iOF = new IOF("ListofRibs.txt");

            smejMatrix = new int[iOF.MyStrA.Length, iOF.MyStrB.Length];
            Console.WriteLine("Смежная матрица");
            FindSmejMatrix();
            Console.WriteLine("Список смежных вершин:");
            SmejVershini();
            Console.WriteLine("Матрица инцидентности");
            GetIncidenceMatrix();
        }
        public static void FindSmejMatrix()
        {

            for (int i = 0; i < iOF.MyStrB.Length; i++)
            {
                for (int j = 0; j < iOF.MyStrA.Length; j++)
                {
                    smejMatrix[iOF.MyStrA[i], iOF.MyStrB[i]] = 1;
                    Console.Write(smejMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void SmejVershini()
        {
            int rows = smejMatrix.GetUpperBound(0) + 1;
            int columns = smejMatrix.Length / rows;

            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < columns; j++)
                {
                    if (smejMatrix[i,j] == 1)
                    {                       
                        myList.Add(j);
                    }
                }
                Console.Write($"V{i}:");
                foreach (var item in myList)
                {
                    Console.Write((item) + " ");
                }
                //edges.Add(new Tuple<int, int>(myList[0], myList[1]));
                Console.WriteLine();
                myList.Clear();
            }
        }
        private static void GetIncidenceMatrix(bool oriented = false)
        {
            edges.Add(new Tuple<int, int>(1, 2));
            edges.Add(new Tuple<int, int>(1, 3));
            edges.Add(new Tuple<int, int>(3, 2));
            edges.Add(new Tuple<int, int>(3, 4));
            edges.Add(new Tuple<int, int>(5, 4));
            edges.Add(new Tuple<int, int>(5, 6));
            edges.Add(new Tuple<int, int>(6, 5));
            var maxEdgeNumber = edges.Select(t => Math.Max(t.Item1, t.Item2)).Max();
            var result = new int[maxEdgeNumber, edges.Count];

            for (int i = 0; i < edges.Count; i++)
            {
                var edge = edges[i];
                result[edge.Item1 - 1, i] = oriented ? -1 : 1;
                result[edge.Item2 - 1, i] = 1;
            }
            for (int i = 0; i < result.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < result.GetLength(1); j++)
                    Console.Write(result[i, j] + " ");
            }
            
        }
    }
}
