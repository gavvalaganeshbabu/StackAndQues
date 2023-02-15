using System;

namespace StackAndQues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack And Ques Application");

            Ques queue = new Ques();
            queue.Enqueue(45);
            queue.Enqueue(89);
            queue.Enqueue(56);
            queue.display();
            queue.Dequeue();
            queue.display();
            queue.Dequeue();
            queue.display();
            queue.Dequeue();
            queue.display();
        }
    }
}
