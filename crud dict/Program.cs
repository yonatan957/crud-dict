using System.Collections.Generic;

namespace crud_dict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Myqueue<string> stringQueue = new Myqueue<string>();
            stringQueue.Enqueue("Hello");
            string value = stringQueue.Dequeue();
            Console.WriteLine(value);

            // שימוש במחלקה עבור תור של מספרים שלמים
            Myqueue<int> intQueue = new Myqueue<int>();
            intQueue.Enqueue(10);
            int number = intQueue.Dequeue();
            Console.WriteLine(number);
        }
    }
}
