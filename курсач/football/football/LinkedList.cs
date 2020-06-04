using System;
using System.Collections.Generic;
using System.Text;

namespace football
{
    class LinkedList<T>
    {
        private LinkedListNode<T> head;
        private int size;

        public LinkedList()
        {
            size = 0;
            head = null;
        }

        public int Size
        {
            get { return size; }
        }

        public void push_back(T data)
        {
            if (head == null)
            {
                head = new LinkedListNode<T>(data);
            }
            else
            {
                LinkedListNode<T> current = this.head;

                while (current.pNext != null)
                {
                    current = current.pNext;
                }
                current.pNext = new LinkedListNode<T>(data);

            }

            size++;
        }

        public T this[int index]
        {
            get
            {
                int counter = 0;
                T result = default(T);
                LinkedListNode<T> current = this.head;

                while (current != null)
                {
                    if (counter == index)
                    {
                        result = current.data;
                    }
                    current = current.pNext;
                    counter++;
                }
                return result;
            }
        }
    }
}
