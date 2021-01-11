using System;
using BinaryTree;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree(new Node(7));

            for (int i = 1; i < 10; i++)
            {
                if (i == 7)
                {
                    return;
                }
                else
                {
                    tree.Add(i);
                }
            }

            Console.Write(tree.Print() + " ");

        }
    }
}
