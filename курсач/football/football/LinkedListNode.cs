using System;
using System.Collections.Generic;
using System.Text;

namespace football
{
    class LinkedListNode<T>
    {
        public T data;
        public LinkedListNode<T> pNext;

        public LinkedListNode(T data, LinkedListNode<T> pNext = null)
        {
            this.data = data;
            this.pNext = pNext;
        }

    }
}
