using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {

        static void Print1to255()
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void PrintOdds1to255()
        {
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 != 0)
                Console.WriteLine(i);
            }
        }

        static void PrintIntsAndSums1to255()
        {
            int Sum = 0;
            for (int i = 1; i <= 255; i++)
            {
                Sum = Sum + i;
                Console.WriteLine($"New Number: {i} Sum: {Sum}");
            }
        }

        static void PrintArray(List<int> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void PrintMax(List<int> arr) 
        {
            int Max = arr[0];
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > Max)
                {
                    Max = arr[i];
                }
            }
            Console.WriteLine(Max);
        }

        static void PrintAverage(List<int> arr)
        {
            int Sum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                Sum = Sum + i;
            }
            Console.WriteLine(Sum/arr.Count);
        }

        static List<int> OddArray() {
            List<int> oddArray = new List<int>();
            for (int i = 0; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    oddArray.Add(i);
                    Console.WriteLine(i);
                }
            }
            return oddArray;
        }

        public static void greaterThanY(List<int> arr, int y)
        {
            int NumGreaterThan = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (i > y)
                {
                    NumGreaterThan = NumGreaterThan + 1;
                }
            }
            Console.WriteLine(NumGreaterThan);
        } 

        public static void squareArrayValues(List<int> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                arr[i] = arr[i] * arr[i];
                Console.WriteLine(arr[i]);
            }
        }

        public static void setNegativesToZero(List<int> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = 0;
                }
                Console.WriteLine(arr[i]);
            }
        }

        public static void MinMaxAverage(List<int> arr)
        {
            int Max = 0;
            int Min = 0;
            int Sum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > Max)
                {
                    Max = arr[i];
                }
                if (arr[i] < Min)
                {
                    Min = arr[i];
                }
                Sum = Sum + arr[i];
            }
            Console.WriteLine(Max);
            Console.WriteLine(Min);
            Console.WriteLine(Sum/arr.Count);
        }

        public static void ShiftValuesToRight(List<int> arr) 
        {
            for (int i = 0; i < arr.Count - 1; i++)
            {
                arr[i] = arr[i + 1];
                Console.WriteLine(arr[i]);
            }
            arr[arr.Count - 1] = 0;
            Console.WriteLine(arr[arr.Count - 1]);
        }

        static void Main(string[] args)
        {
            List<int> arr = new List<int>() {
                3,
                -4,
                7,
                12,
                -11,
                0,
                -2
            };
            NumToString(arr);
        }
    }
}