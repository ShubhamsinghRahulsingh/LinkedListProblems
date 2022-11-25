using System;
namespace LinkedListProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to the LinkedList Operations");
           // LinkedList list = new LinkedList();
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //list.Display();
            //int position = list.Search(30);
            //list.InsertAtParticuarPosition(position + 1, 40);
            //list.Display();
            LinkedListStack stack = new LinkedListStack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
           stack.Display();
            //  stack.Peek();
            //stack.Pop();
            //stack.Display();
            //LinkedListQueue queue=new LinkedListQueue();
            //queue.Enqueue(56);
            //queue.Enqueue(30);
            //queue.Enqueue(70);
            //queue.Display();
            //queue.Dequeue();
            //queue.Display();
        }
    }
}
