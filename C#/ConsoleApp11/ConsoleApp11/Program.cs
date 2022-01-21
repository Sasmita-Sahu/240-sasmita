using System;
using System.Collections;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQueue = new Queue();
            myQueue.Enqueue("hello");
            myQueue.Enqueue(null);
            myQueue.Enqueue(10);
            myQueue.Enqueue(23);
            myQueue.Enqueue(30);
            myQueue.Enqueue(40);
            myQueue.Dequeue();

            Console.WriteLine("total no of element in queuee ", myQueue.Count);
            foreach(var item in myQueue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
