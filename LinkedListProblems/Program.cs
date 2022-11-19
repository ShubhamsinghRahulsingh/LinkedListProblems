using System;
namespace LinkedListProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LinkedList Operations");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            int position = list.Search(30);
            list.InsertAtParticuarPosition(position + 1, 40);
            list.Display();
        }
    }
}
