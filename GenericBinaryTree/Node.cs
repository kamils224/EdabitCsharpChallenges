using System;
using System.Collections.Generic;

// task: https://edabit.com/challenge/tbfAdu3QMCBAQrqre

namespace GenericBinaryTree
{
    public class Node<T> where T: IComparable 
    {
        public Node(T data) 
        {
            Data = data;
        }

        public Node<T> Left {get; private set; }
        public Node<T> Right {get; private set; }
        public T Data {get; private set; }

        public void Insert(T data)
        {
            if (data.CompareTo(Data) == -1)
            {
                if (Left != null)
                {
                    Left.Insert(data);
                }
                else
                {
                    Left = new Node<T>(data);
                }
            }
            else
            {
                if (Right != null)
                {
                    Right.Insert(data);
                }
                else
                {
                    Right = new Node<T>(data);
                }
            }
        }

        public IEnumerable<T> GetTreeData()
        {
            var result = new List<T>();
            var visited = new Stack<Node<T>>();
            var currentNode = this;

            while (true)
            {
                if (currentNode != null)
                {
                    visited.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                else if (visited.Count > 0)
                {
                    currentNode = visited.Pop();
                    result.Add(currentNode.Data);
                    currentNode = currentNode.Right;
                }
                else
                {
                    break;
                }
            }
            return result;
        }
    }
}
