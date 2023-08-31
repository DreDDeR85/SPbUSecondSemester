using System;

namespace hw1t1
{
    /// <summary>
    /// Internal class Program.
    /// </summary>
    internal class Program
    {
        public static void InsertionSort(int[] array, int arrayLength)
        {
            int temp = 0;
            int j = 0;
            for (int i = 1; i < arrayLength; i++)
            {
                temp = array[i];
                j = i - 1;
                while (j >= 0 && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
        }
        public static void PrintArray(int[] array, int arrayLength)
        {
            var TempString = "";
            for (int i = 0; i < arrayLength; ++i)
            {
                TempString = array[i].ToString() + " ";
                Console.Write(TempString);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please, give me a n - the natural");
            Console.WriteLine("number and then n integer numbers - the numbers of array.");
            Console.WriteLine("I will print on your screen sorted array.");
            int n = 0;
            bool correctInput = int.TryParse(Console.ReadLine(), out n);
            while (!correctInput)
            {
                Console.WriteLine("Incorrect enter! Please, try again!");
                correctInput = int.TryParse(Console.ReadLine(), out n);
            }
            var array = new int[n];
            Console.WriteLine("Now, please, enter the {0} elements of your array", n.ToString());
            for (int i = 0; i < n; ++i)
            {
                correctInput = int.TryParse(Console.ReadLine(), out array[i]);
                while (!correctInput)
                {
                    Console.WriteLine("Incorrect enter! Please, try again!");
                    correctInput = int.TryParse(Console.ReadLine(), out array[i]);
                }
            }
            InsertionSort(array, n);
            Console.WriteLine("Here is your sorted array!");
            PrintArray(array, n);
        }
    }
}
