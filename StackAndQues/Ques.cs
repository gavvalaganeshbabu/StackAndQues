using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StackAndQues
{
    internal class Ques
    {
        Node front;
        Node rear;

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (this.rear == null)
            {
                this.front = this.rear = newNode;
            }
            else
            {
                this.rear.next = newNode;
                this.rear = newNode;
            }
            Console.WriteLine($"{data} Inserted into Queue");
        }
        public void Dequeue()
        {
            if (this.front == null)
            {
                Console.WriteLine(" Queue is Empty");
                return;
            }
            Node temp = this.front;
            this.front = this.front.next;

            if (this.front == null)
            {
                this.rear = null;
            }

            Console.WriteLine("Element deleted is {0}", temp.data);
        }
        public void display()
        {
            int i = 1;
            int size = 0;
            Node temp = front;
            if (temp == null)
            {
                Console.WriteLine(" Queue is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine($"{i}st Element in the Queue is : " + temp.data);
                temp = temp.next;
                size = i;
                i++;
            }
            Console.WriteLine(" Total Element of Que is :" + size);
        }
    }
}
