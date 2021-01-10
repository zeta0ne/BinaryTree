using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public interface ITree
    {
        void Add(int value);
        string Print();
        void Remove(int value);
        void Find(int value);
    }
}
