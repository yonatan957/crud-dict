namespace crud_dict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Myqueue queue = new Myqueue();
            queue.Enqueue(1);
            queue.Enqueue("ba");
            Console.WriteLine(queue.Peek);
            Console.WriteLine(queue.Dequeue);
            Console.WriteLine(queue.Dequeue);
        }
    }
}
