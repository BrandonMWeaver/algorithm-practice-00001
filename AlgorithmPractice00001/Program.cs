using System;
using System.CodeDom.Compiler;
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
            Console.Write("Max: ");
            Console.WriteLine(Max(integerArray));

            // Min
            Console.Write("Min: ");
            Console.WriteLine(Min(integerArray));

            // Sort
            Console.Write("Srt: ");
            Sort(integerArray);
            PrintArray(integerArray);

            // Sum
            Console.Write("Sum: ");
            Console.WriteLine(Sum(integerArray));

            // Reverse
            Console.Write("Rvs: ");
            Reverse(integerArray);
            PrintArray(integerArray);

            // Average
            Console.Write("Avg: ");
            Console.WriteLine(Average(integerArray));
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

        static int Sum(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
                sum += i;
            return sum;
        }

        static void Reverse(int[] arr)
        {
            int i = 0;
            int j = arr.Length - 1;
            while (i < arr.Length)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
                if (i < j) break;
            }
        }

        static int Average(int[] arr)
        {
            return Sum(arr) / arr.Length;
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (!(i == arr.Length - 1))
                    Console.Write($"{arr[i]}, ");
                else
                    Console.WriteLine(arr[i]);
            }
        }
    }
}
