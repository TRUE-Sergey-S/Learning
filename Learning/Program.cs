﻿using System;
using System.Collections.Generic;
using System.Text;
using static Learning.СodeFeaturesLearning.BinarySearchTree;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var intArray = new List<int> { 1, 3, 2, 3, 4, 1 };
            StringBuilder resultFindUp = new StringBuilder();
            StringBuilder resultFindDown = new StringBuilder();
            for (int i = 0; i < intArray.Count; i++)
            {
                bool find = false;
                for (int j = i + 1; j < intArray.Count; j++)
                {
                    if (intArray[i] == intArray[j])
                    {
                        find = true;
                        resultFindUp.Append("1");
                        j = intArray.Count;
                    }
                }
                if (!find)
                {
                    resultFindUp.Append("0");
                }
                find = false;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (intArray[i] == intArray[j])
                    {
                        find = true;
                        resultFindDown.Append("1");
                        j -= intArray.Count;
                    }
                }
                if (!find)
                {
                    resultFindDown.Append("0");
                }
            }
            Console.WriteLine(resultFindDown);
            Console.WriteLine(resultFindUp);
        }
    }
}