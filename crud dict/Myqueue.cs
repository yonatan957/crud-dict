using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_dict
{
    internal class Myqueue
    {
        public Queue myQueue = new Queue();
        public void Clear() { myQueue.Clear(); }
        public void Enqueue(string value) {myQueue.Enqueue(value); }
        public void Enqueue(int value) {myQueue.Enqueue(value); }
        public string Dequeue() { return myQueue.Dequeue(); }
        public void Peek() { myQueue.Peek(); }
    }
}
