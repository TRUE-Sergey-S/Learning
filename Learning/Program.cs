using System;
using System.Collections.Generic;
using static Learning.СodeFeaturesLearning.BinarySearchTree;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var intArray = new List<int> { 1, 3, 2, 3, 4, 1 };
            var midleIndex = intArray.Count / 2;
            var bst = new BinaryTreeNode<int>(intArray[0]);
            for (int i = 1; i < intArray.Count; i++)
            {
                bst.Add(intArray[i]);
            }
            bst.PrintTreeOnConsole();
            Console.WriteLine("Element Count = "+ bst.SerchElementCount(1));
            Console.ReadLine();
        }
    }
}
