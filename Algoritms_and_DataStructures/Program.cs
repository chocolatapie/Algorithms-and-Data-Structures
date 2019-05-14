using System;
using Algoritms_and_DataStructures.LinkedList;

namespace Algoritms_and_DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LinkedList
            Console.WriteLine("This is our linked list: ");
            LinkedList.LinkedList myList = new LinkedList.LinkedList();
            myList.AddLastValue(5);
            myList.AddLastValue(4);
            myList.AddLastValue(3);
            myList.AddLastValue(2);
            myList.AddLastValue(1);
            myList.AddLastValue(2);
            Node node7 = new Node(3);
            Node node8 = new Node(4);
            Node node9 = new Node(5);
            myList.AddLastNode(node7);
            myList.AddLastNode(node8);
            myList.AddLastNode(node9);
            foreach (Node node in myList)
            {
                if (node.NextNode != null)
                {
                    Console.Write(node.Value + "->");
                }
                if (node.NextNode == null)
                {
                    Console.Write(node.Value);
                }
            }
            Console.WriteLine();
            Console.WriteLine();


            bool isPalindrome = myList.IsPalindrome();
            Console.WriteLine("Is our list a palindrome? : ");
            Console.WriteLine(isPalindrome);
            Console.WriteLine();


            Console.WriteLine("Here is the 4th node value from end:");
            Console.WriteLine(myList.NthNodeValueFromEnd(4));
            Console.WriteLine();


            Console.WriteLine("Here, we remove duplicates:");
            myList.RemoveDuplicates();
            foreach (Node node in myList)
            {
                if (node.NextNode != null)
                {
                    Console.Write(node.Value + "->");
                }
                if (node.NextNode == null)
                {
                    Console.Write(node.Value);
                }
            }
            Console.WriteLine();


            Console.ReadKey();
            #endregion
        }
    }
}
