using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQues
{
    internal class Stack
    {
        public Node top;

        public Stack()
        {
            this.top = null;
        }
        public void push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
            Console.WriteLine(" Pushed to Stack value =" + data);
        }
        public void peak()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine($"{this.top.data} is the Top of the Stack");
        }
        public void pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine($"Item Poped is {this.top.data}");
            top = top.next;
        }

        public void display()
        {
            int i = 1;
            int size = 0;
            Node temp = top;
            if (temp == null)
            {
                Console.WriteLine(" Stack is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine($"  {i} st Element in Stack = " + temp.data);
                temp = temp.next;
                size = i;
                i++;
            }
            Console.WriteLine(" Total Elements of Stack = " + size);
        }
    }
}
