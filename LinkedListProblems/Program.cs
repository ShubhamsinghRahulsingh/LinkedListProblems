using System;
namespace LinkedListProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Console.WriteLine("Welcome to the LinkedList Operations");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n_________________________________________________");
                Console.WriteLine("Select the operation to perform\n1.Create LinkedList\n2.Display\n3.Exit");
                int choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        break;
                    case 2:
                        list.Display();
                        break;
                    case 3:
                        flag = false;
                        break;
                }

            }
        }
    }
}
