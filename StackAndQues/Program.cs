using System;

namespace StackAndQues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack And Ques Application");
            Stack stack = new Stack();
            stack.push(78);
            stack.push(69);
            stack.push(89);
            stack.display();
        }
    }
}
