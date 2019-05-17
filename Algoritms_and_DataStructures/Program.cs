using System;
using Algoritms_and_DataStructures.MathOperationFromIncrement;
using Algoritms_and_DataStructures.ReversLettersOnly;
using Algoritms_and_DataStructures.StackAndQueue;
using Algoritms_and_DataStructures.StringAlgorythms;
using Algoritms_and_DataStructures.SwitchVariables;
using Node = Algoritms_and_DataStructures.LinkedList.Node;

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
            Console.WriteLine(permut1+" "+permut2+" "+CustomStringAlgorythms.IsPermutation(permut1, permut2));
            Console.WriteLine(permut3 + " " + permut4 + " " + CustomStringAlgorythms.IsPermutation(permut3, permut4));
            Console.WriteLine();
            //

            //Compressor
            Console.WriteLine("Compresses the long string");
            string compress1 = "aaaaaavvvvvvfghhhjjk";
            string compress2 = "asdfghj";
            Console.WriteLine(CustomStringAlgorythms.StringCompress(compress1));
            Console.WriteLine(CustomStringAlgorythms.StringCompress(compress2));
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine();
            //
            #endregion

            #region StackAndQueue
            CustomStack myStack = new CustomStack();
            myStack.Push(4);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(0);
            myStack.Push(4);
            myStack.Push(6);
            myStack.Push(7);
            myStack.Push(9);
            Console.WriteLine("First stack is the origin one. " +
                              "Second - is with bubbled minValue.");
            foreach (NodeSQ node in myStack)
            {
                Console.WriteLine(" " + node.Value);
            }

            Console.WriteLine();
            Console.WriteLine("--------");
            myStack.BubbleMinUp();
            foreach (NodeSQ node in myStack)
            {
                Console.WriteLine(" " + node.Value);
            }
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine();
            #endregion

            #region ReverseLettersOnly
            string input = "abc@#def*&gh";
            Console.WriteLine("Our original string :");
            Console.WriteLine(input);
            Console.WriteLine();

            Console.WriteLine("And here only letters reversed:");
            LettersReverser.ReverseLettersOnly(input);
            Console.WriteLine(LettersReverser.ReverseLettersOnly(input));
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine();

            #endregion

            #region SwitchVariables
            int Aaa = 4;
            int Bbb = 9;

            Console.WriteLine("Origin: ");
            Console.WriteLine("A = {0}", Aaa);
            Console.WriteLine("B = {0}", Bbb);

            VarSwitcher.Switch(ref Aaa, ref Bbb);
            Console.WriteLine();

            Console.WriteLine("Reversed:");
            Console.WriteLine("A = {0}", Aaa);
            Console.WriteLine("B = {0}", Bbb);
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine();
            #endregion
            
            Console.ReadKey();
        }
    }
}
