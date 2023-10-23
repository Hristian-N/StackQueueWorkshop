using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace StackQueueWorkshop.Queue
{
    public class ArrayQueue<T> : IQueue<T>
    {
        private T[] items;
        private int tail;

        public ArrayQueue()
        {
            items = new T[16];
            tail = 0;
        }

        public int Size
        {
            get
            {
                return this.tail;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return (Size == 0);
            }
        }

        public void Enqueue(T element)
        {
            // adds a node to the tail

            items[tail] = element;
            tail++;
        }

        public T Dequeue()
        {
            // removes a node from the head;

            if (IsEmpty)
                throw new InvalidOperationException();

            T element = items[0];

            for (int i = 0; i < tail; i++)
            {
                items[i] = items[i + 1];
            }

            tail--;

            return element;
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            return items[0];
        }
    }
}
