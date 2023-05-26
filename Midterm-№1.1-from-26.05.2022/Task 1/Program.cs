using System;
using System.Collections.Generic;

namespace BubbleSort
{
    /// <summary>
    /// Class representing bubble sort for any type of object'
    /// </summary>
    /// <typeparam name="T">Values that array for bubble sort contains</typeparam>
    /// <param name="comparer">Object which sets the comparison relation on our array</param>
    class Program
    {
        static void Main(string[] args)
        {
            //The example of sort usage

            List<int> intList = new List<int>() { 7, 4, 2, 10 };
            Console.WriteLine("Initial data:" + string.Join(",", intList));

            BubbleSort(intList);

            Console.WriteLine("Output data:" + string.Join(",", intList));
        }

        public static void BubbleSort<T>(IList<T> list, IComparer<T> comparer = null)
        {
            if (list == null || list.Count <= 1)
            {
                return;
            }
            if (comparer == null)
            {
                comparer = Comparer<T>.Default;
                // if the comparer is not specified,
                // then we will use the standart
            }

            for (int i = 0; i < list.Count; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    if (comparer.Compare(list[j], list[j + 1]) > 0)
                    {
                        T temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }
    }
}