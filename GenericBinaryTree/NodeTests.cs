using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;


namespace GenericBinaryTree
{
    [TestFixture]
    public class Tests
    {
        class MyWord : IComparable
        {
            public MyWord(string data)
            {
                Word = data;
            }

            public string Word { get; private set; }

            public int CompareTo(object obj)
            {
                if (obj == null) return Word == null ? 0 : 1;
                if (!(obj is MyWord)) throw new ArgumentException("Can't compare apples with oranges");
                return Word?.Length.CompareTo(((MyWord)obj).Word.Length) ?? -1;
            }
        }

        [Test]
        public static void TestBinaryTree()
        {
            var root = new Node<int>(10);
            root.Insert(5);
            root.Insert(3);
            root.Insert(12);
            root.Insert(13);
            root.Insert(11);
            root.Insert(6);
            Assert.AreEqual(string.Join(", ", root.GetTreeData().Select(d => d.ToString())), "3, 5, 6, 10, 11, 12, 13");
            Assert.AreEqual(root.Data, 10);
            Assert.AreEqual(root.Left.Data, 5);
            Assert.AreEqual(root.Left.Left.Data, 3);
            Assert.AreEqual(root.Left.Right.Data, 6);
            Assert.AreEqual(root.Right.Data, 12);
            Assert.AreEqual(root.Right.Left.Data, 11);
            Assert.AreEqual(root.Right.Right.Data, 13);

            var root2 = new Node<string>("13");
            root2.Insert("5");
            root2.Insert("3");
            root2.Insert("11");
            root2.Insert("12");
            root2.Insert("10");
            root2.Insert("6");
            Assert.AreEqual(string.Join(", ", root2.GetTreeData()), "10, 11, 12, 13, 3, 5, 6");
            Assert.AreEqual(root2.Data, "13");
            Assert.AreEqual(root2.Left.Data, "11");
            Assert.AreEqual(root2.Left.Left.Data, "10");
            Assert.AreEqual(root2.Left.Right.Data, "12");
            Assert.AreEqual(root2.Right.Data, "5");
            Assert.AreEqual(root2.Right.Left.Data, "3");
            Assert.AreEqual(root2.Right.Right.Data, "6");

            var root3 = new Node<MyWord>(new MyWord("eleven"));
            root3.Insert(new MyWord("four"));
            root3.Insert(new MyWord("fifteen"));
            root3.Insert(new MyWord("six"));
            root3.Insert(new MyWord("eight"));
            root3.Insert(new MyWord("thirteen"));
            Assert.AreEqual(string.Join(", ", root3.GetTreeData().Select(mw => mw.Word)), "six, four, eight, eleven, fifteen, thirteen");
            Assert.AreEqual(((MyWord)root3.Data).Word, "eleven");
            Assert.AreEqual(((MyWord)root3.Left.Data).Word, "four");
            Assert.AreEqual(((MyWord)root3.Left.Left.Data).Word, "six");
            Assert.AreEqual(((MyWord)root3.Left.Right.Data).Word, "eight");
            Assert.AreEqual(((MyWord)root3.Right.Data).Word, "fifteen");
            Assert.AreEqual(((MyWord)root3.Right.Right.Data).Word, "thirteen");
            Assert.AreEqual(root3.Right.Left, null);
        }  
    }
}
