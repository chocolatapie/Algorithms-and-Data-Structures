using System;
using Algoritms_and_DataStructures.LinkedList;
using Algoritms_and_DataStructures.MathOperationFromIncrement;
using Algoritms_and_DataStructures.StringAlgorythms;

namespace Algoritms_and_DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LinkedList
            Console.WriteLine("Linked List: ");
            Console.WriteLine();
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
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine();
            #endregion

            #region MathOperations
            Console.WriteLine("Math operations: ");
            Console.WriteLine();
            Console.WriteLine("Substraction: ");
            int A = 4;
            int B = 9;

            int C = MathOperationsFromIncrement.Substraction(A, B);
            Console.WriteLine("{0} - {1} = {2}", A, B, C);
            Console.WriteLine();

            Console.WriteLine("Multiplication: ");
            int D = MathOperationsFromIncrement.Multiplication(A, B);
            Console.WriteLine("{0} * {1} = {2}", A, B, D);

            Console.WriteLine();
            Console.WriteLine("Division: ");
            int Aa = 100;
            int Bb = 25;
            int Cc = MathOperationsFromIncrement.Division(Aa, Bb);
            Console.WriteLine("{0} / {1} = {2}", Aa, Bb, Cc);
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine();
            #endregion

            #region StringAlgorythms
            Console.WriteLine("Checks is all symbols in string is unique");
            string first = "asdfghjkl";
            string second = "asdfghhjkl";
            string third = "aaasdfghjkl";
            string fourth = "asdfghjj";
            string fifth = "asdfghjklzmxncbv";
            Console.WriteLine(first + " " + "---" + " " + CustomStringAlgorythms.AreAllSymbolsUnique(first));
            Console.WriteLine(second + " " + "---" + " " + CustomStringAlgorythms.AreAllSymbolsUnique(second));
            Console.WriteLine(third + " " + "---" + " " + CustomStringAlgorythms.AreAllSymbolsUnique(third));
            Console.WriteLine(fourth + " " + "---" + " " + CustomStringAlgorythms.AreAllSymbolsUnique(fourth));
            Console.WriteLine(fifth + " " + "---" + " " + CustomStringAlgorythms.AreAllSymbolsUnique(fifth));
            Console.WriteLine();

            //IsPermutation
            Console.WriteLine();
            Console.WriteLine("Checks if first string is only a permutation of another one: ");
            string permut1 = "asdfgh";
            string permut2 = "hgfdsa";
            string permut3 = "aaasssdddff";
            string permut4 = "aassssddfff";
            Console.WriteLine(CustomStringAlgorythms.IsPermutation(permut1, permut2));
            Console.WriteLine(CustomStringAlgorythms.IsPermutation(permut3, permut4));
            Console.WriteLine();
            //

            //Compressor
            Console.WriteLine("Compresses the long string");
            string compress1 = "aaaaaavvvvvvfghhhjjk";
            string compress2 = "asdfghj";
            Console.WriteLine(CustomStringAlgorythms.StringCompress(compress1));
            Console.WriteLine(CustomStringAlgorythms.StringCompress(compress2));
            Console.WriteLine();
            //
            #endregion

            Console.ReadKey();
        }
    }
}
