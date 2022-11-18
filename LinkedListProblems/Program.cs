using System;
namespace LinkedListProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Console.WriteLine("Welcome to the LinkedList Operations");
            Console.WriteLine("Select the operation to perform\n1.Create LinkedList\n2.Add Data In Reverse Order\n3.Insert At Particular Place in LinkedList\n4.Remove First Node\n5.Remove Last Node\n6.Search Node Value in LinkedList");
            Console.Write("Enter your choice: ");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    list.Display();
                    break;
                case 2:
                    list.AddInReverseOrder(70);
                    list.AddInReverseOrder(30);
                    list.AddInReverseOrder(56);
                    list.Display();
                    break;
                case 3:
                    list.Add(56);
                    list.Add(70);
                    list.Display();
                    list.InsertAtParticuarPosition(1, 30);
                    list.Display();
                    break;
                case 4:
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    list.RemoveFirstNode();
                    list.Display();
                    break;
                case 5:
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    list.RemoveLastNode();
                    list.Display();
                    break;
                case 6:
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    int find=list.Search(30);
                    Console.WriteLine("The Position of Node with value 30 in LinkedList is "+find);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}
