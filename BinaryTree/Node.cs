using System;

namespace BinaryTree
{
    public class Node
    {
        public Node(int value)
        {
            Value = value;
        }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }
        public long Count { get; set; } = 1;

        public override string ToString()
        {
            return $"{Value}";

        }
    }
}
