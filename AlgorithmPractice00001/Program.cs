using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice00001
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = { 20, 15, 5, 25, 45, 30, 35 };
            Console.WriteLine(Max(integerArray));
            Console.WriteLine(Min(integerArray));
        }

        static int Max(int[] arr)
        {
            int max = arr[0];
            foreach (int i in arr)
            {
                if (i > max)
                    max = i;
            }
            return max;
        }

        static int Min(int[] arr)
        {
            int min = arr[0];
            foreach (int i in arr)
            {
                if (i < min)
                    min = i;
            }
            return min;
        }
    }
}
