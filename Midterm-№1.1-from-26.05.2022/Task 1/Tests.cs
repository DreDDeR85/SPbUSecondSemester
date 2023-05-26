using System;
using System.Collections.Generic;
using NUint.Framework;

namespace BubbleSort.tests;

public class Tests
{
    [TestFixture]
    public class BubbleSortTests
    {
        [Test]
        public void SortInList()
        {
            List<int> intList = new List<int>() { 5, 3, 9, -4 };
            Program.BubbleSort(intList);

            Assert.AreEqual(new List<int>() { -4, 3, 5, 9 }, intList);
        }

        [Test]
        public void SortStringArray()
        {
            string[] strArr = { "Lord of the Rings", "The Witcher", "The Twelve Chairs", "Harry Potter" };
            Program.BubbleSort(strArr, Comparer<string>.Default);

            Assert.AreEqual(new string[] { "Harry Potter", "Lord of the Rings", "The Twelve Chairs", "The Witcher" }, strArr);
        }

        [Test]
        public void SortCustomObjectList()
        {
            List<Statue> statue = new List<Statue>()
            {
                new Statue() {Name = "The Motherland Calls", Height = 85, City = "Volgograd"},
                new Statue() {Name = "Statue of Liberty", Height = 46, City = "New York"},
                new Statue() {Name = "Christ the Redeemer", Height = 30, City = "Rio de Janeiro"},
            };

            //sort by the height
            Program.BubbleSort(statue, Comparer<Statue>.Create((s1, s2) => s1.Height.CompareTo(s2.Height)));

            Assert.AreEqual(new List<Statue>()
            {
                new Statue() {Name = "The Motherland Calls", Height = 85, City = "Volgograd"},
                new Statue() {Name = "Statue of Liberty", Height = 46, City = "New York"},
                new Statue() {Name = "Christ the Redeemer", Height = 30, City = "Rio de Janeiro"},
            }, statue;
        }
    }

    class Statue
    {
        public string Name;
        public int Height;
        public string City;
    }
}