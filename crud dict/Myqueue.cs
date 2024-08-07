using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_dict
{
    internal class Myqueue<T>
    {
        private Queue<T> myQueue = new Queue<T>();

        public void Clear()
        {
            myQueue.Clear();
        }

        public void Enqueue(T value)
        {
            myQueue.Enqueue(value);
        }

        public T Dequeue()
        {
            return myQueue.Dequeue();
        }

        public T Peek()
        {
            return myQueue.Peek();
        }
    }
}
