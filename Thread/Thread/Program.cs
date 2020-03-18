using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread
{
    class Program
    {
        public static double[] b { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов: ");
            int n = Console.Read();
            int[] array = new int[n];
            int[] arrayFill = Fill(array);
            Treatment(arrayFill);
            Console.WriteLine(b);
        }
        public static int[] Fill(int[] array)
        {
            Random random = new Random();            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
            }
            return array;
        }

        public static void Treatment(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                    b[i] += Math.Pow(array[i], 1.789);
            }
        }
    }
}
