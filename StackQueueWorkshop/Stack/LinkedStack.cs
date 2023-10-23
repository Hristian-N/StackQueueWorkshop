using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueWorkshop.Stack
{
    public class LinkedStack<T> : IStack<T>
    {
        private Node<T> top;
        private int size;

        public LinkedStack()
        {
            top = null;
            size = 0;
        }

        public int Size
        {
            get
            {
                return this.size;
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
            Node<T> tmp = new Node<T>();
            tmp.Data = element;
            tmp.Next = top;

            top = tmp;

            size++;
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            Node<T> tmp = top;
            top = top.Next;
            return tmp.Data;
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            return top.Data;
        }
    }
}
