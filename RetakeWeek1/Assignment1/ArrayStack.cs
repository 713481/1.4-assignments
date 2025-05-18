using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ArrayStack : IStack
    {
        private int[] items;
        private int top;

        public ArrayStack(int size)
        {
            items = new int[size];
            top = -1;
        }
        public void Push(int number)
        {
            if (top + 1 >= items.Length)
            {
                throw new InvalidOperationException("Stack is full.");
            }
            top++;
            items[top] = number;
        }
        public int Pop()
        {
            if ( top == -1)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            int value = items[top];
            top--;
            return value;
        }

        public bool Contains(int value)
        {
            for (int i = 0; i <= top; i++)
            {
                if (items[top] == value)
                {
                    return true;
                }
            }
            return false;
        }

        public int Count
        {
            get { return top + 1; }
        }

        public bool IsEmpty
        {
            get { return top < 0; }
        }
    }
}
