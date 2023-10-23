using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueWorkshop.Queue
{
    public class LinkedQueue<T> : IQueue<T>
    {
        private Node<T> head, tail;
        private int size;

        public LinkedQueue()
        {
            head = new Node<T>();
            tail = new Node<T>();
            this.size = 0;
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

        public void Enqueue(T element)
        {
            // adds a node to the tail

            Node<T> tmp = new Node<T>();
            tail.Next = tmp;

            tmp.Data = element;
            tail = tmp;

            if (IsEmpty)
                head = tmp;

            this.size++;
        }

        public T Dequeue()
        {
            // removes a node from the head

            if (IsEmpty)
                throw new InvalidOperationException();

            Node<T> tmp = head;
            head = head.Next;
            return tmp.Data;
        }

        public T Peek()
        {
            // return the head

            if (IsEmpty)
                throw new InvalidOperationException();

            return head.Data;
        }
    }
}
