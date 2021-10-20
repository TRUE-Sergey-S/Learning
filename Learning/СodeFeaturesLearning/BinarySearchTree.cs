using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.СodeFeaturesLearning
{
    class BinarySearchTree
    {
        public class BinaryTreeNode<T> where T : IComparable<T>
        {
            private T data;
            private BinaryTreeNode<T> leftNode;
            private BinaryTreeNode<T> rightNode;
            private BinaryTreeNode<T> parentNode;
            private int elementCount = 0;
            private StringBuilder returnStringUp = new StringBuilder();
            private StringBuilder returnStringDown = new StringBuilder();
            public BinaryTreeNode(T value)
            {
                data = value;
            }
            public BinaryTreeNode(T value, BinaryTreeNode<T> parent)
            {
                parentNode = parent;
                data = value;
            }
            public void PrintTreeOnConsole() {
                Console.WriteLine("ParentNode value = " + data);
                
                if (leftNode != null)
                {
                    Console.WriteLine();
                    Console.Write("LeftTree: ");
                    printTree(leftNode);
                    Console.WriteLine();
                    Console.WriteLine("ElementInBranhc = " + elementCount);
                }
                if (rightNode != null) {
                    elementCount = 0;
                    Console.WriteLine();
                    Console.Write("RightTree: ");
                    printTree(rightNode);
                    Console.WriteLine();
                    Console.WriteLine("ElementInBranhc = " + elementCount);
                }
            }
            public int SerchElementCount(T value) {
                int elementCounts = 0;
                Serch(value, this);
                void Serch(T value, BinaryTreeNode<T> node)
                {
                    if (node != null)
                    {
                        if (value.CompareTo(node.data) < 0)
                        {
                            Serch(value, node.leftNode);
                        }
                        else if (value.CompareTo(node.data) == 0)
                        {
                            elementCounts++;
                            Serch(value, node.rightNode);
                        }
                        else
                        {
                            Serch(value, node.rightNode);
                        }
                    }
                    else { return; }
                }
                return elementCounts;
            }
            private void printTree(BinaryTreeNode<T> node) {
                if (node == null) return;
                printTree(node.leftNode);
                Console.Write(node.data + " ");
                elementCount++;
                if (node.rightNode != null)
                {
                    printTree(node.rightNode);
                }
            }
            public void Add(T value) {
                if (value.CompareTo(data) < 0)
                {
                    if (leftNode == null)
                    {
                        leftNode = new BinaryTreeNode<T>(value, this);
                    }
                    else { leftNode.Add(value); }
                }
                else {
                    if (rightNode == null)
                    {
                        rightNode = new BinaryTreeNode<T>(value, this);
                    }
                    else { rightNode.Add(value); }
                }
            }
        }
    }
}
