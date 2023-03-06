using System;
using System.Globalization;
using System.Xml.Linq;

namespace hw1t1
{
    internal class Program
    {
        public static void InsertionSort(int[] array, int ArrayLength)
        {
            int temp = 0;
            int j = 0;
            for (int i = 1; i < ArrayLength; i++)
            {
                temp = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j] > temp))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
        }
        public static void PrintArray(int[] array, int ArrayLength)
        {
            string TempString = null;
            for (int i = 0; i < ArrayLength; ++i)
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
            bool CorrectInput = int.TryParse(Console.ReadLine(), out n);
            while (!CorrectInput)
            {
                Console.WriteLine("Incorrect enter! Please, try again!");
                CorrectInput = int.TryParse(Console.ReadLine(), out n);
            }
            int[] array = new int[n];
            string HelpString = "Now, please, enter the " + n.ToString() + " elements of your array";
            Console.WriteLine(HelpString);
            for (int i = 0; i < n; ++i)
            {
                CorrectInput = int.TryParse(Console.ReadLine(), out array[i]);
                while (!CorrectInput)
                {
                    Console.WriteLine("Incorrect enter! Please, try again!");
                    CorrectInput = int.TryParse(Console.ReadLine(), out array[i]);
                }
            }
            InsertionSort(array, n);
            Console.WriteLine("Here is your sorted array!");
            PrintArray(array, n);
        }
    }
}
