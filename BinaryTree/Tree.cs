using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Tree : ITree
    {
        private Node _root;

        public Tree(Node root)
        {
            _root = root;
        }

        public void Add(int value)
        {
            Add(_root, value);
        }

        private Node Add(Node node, int value)
        {
            if (node == null)
            {
                node = new Node(value);
                return node;
            }

            if (value < node.Value)
            {
                node.Left = Add(node.Left, value); //метод вызывает сам себя
            }

            if (value > node.Value)
            {
                node.Right = Add(node.Right, value);
            }

            if (value == node.Value)
            {
                node.Count++;
            }

            return node;
        }

        public void Find(int value)
        {
            throw new NotImplementedException();
        }

        public string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb = Print(_root, sb);
            return sb.ToString();
        }

        private StringBuilder Print (Node node, StringBuilder sb)
        {
            if (node == null)
            {
                return sb;
            }

            Print(node.Left, sb); //метод вызывает сам себя
            sb.Append(node.Value); 
            Print(node.Right, sb);

            return sb;
        }

        public void Remove(int value)
        {
            throw new NotImplementedException();
        }
    }
}
