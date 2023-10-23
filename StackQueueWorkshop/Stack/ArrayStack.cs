using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueWorkshop.Stack
{
    public class ArrayStack<T> : IStack<T>
    {
        private T[] items;
        private int top;
        private int limit = 4;

        public ArrayStack()
        {
            items = new T[limit];
            top = -1;
        }

        public int Size
        {
            get
            {
                return top + 1;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return (Size == 0);
            }
        }

        public void Push(T element)
        {

            if (top == limit - 1)
            {
                limit *= 2;

                T[] tmp = items;
                items = new T[limit];

                Array.Copy(tmp, items, top + 1);

            }

            top++;
            items[top] = element;
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            return items[top--];
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            return items[top];
        }
    }
}
