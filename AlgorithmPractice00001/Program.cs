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

            // Max
            Console.WriteLine(Max(integerArray));

            // Min
            Console.WriteLine(Min(integerArray));

            // Sort
            Sort(integerArray);
            for(int i = 0; i < integerArray.Length; i++)
            {
                if (!(i == integerArray.Length - 1))
                    Console.Write($"{integerArray[i]}, ");
                else
                    Console.WriteLine(integerArray[i]);
            }
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

        static void Sort(int[] arr)
        {
            for (int i = arr.Length - 1; i > 0; i--)
                for (int j = 0; j < i; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }
    }
}
