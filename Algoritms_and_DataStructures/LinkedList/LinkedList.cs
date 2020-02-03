using System.Collections.Generic;

namespace Algoritms_and_DataStructures.LinkedList
{
    class LinkedList
    {
        private int _numberOfNodes;
        private Node _headNode;

        public int Count => _numberOfNodes;

        public void AddLastValue(int input)
        {
            if (_headNode == null)
                _headNode = new Node(input);
            else
            {
                Node current = _headNode;
                while (current.NextNode != null)
                    current = current.NextNode;

                current.NextNode = new Node(input);
            }
            _numberOfNodes++;
        }

        public void AddLastNode(Node node)
        {
            if (_headNode == null)
                _headNode = node;
            else
            {
                Node currentNode = _headNode;
                while (currentNode.NextNode != null)
                    currentNode = currentNode.NextNode;

                currentNode.NextNode = node;
            }
            _numberOfNodes++;
        }

        public void DeleteNode(Node node)
        {
            if (node == _headNode)
                _headNode = _headNode.NextNode;
            else
            {
                Node current = _headNode;
                while (current.NextNode != null)
                {
                    if (current.NextNode == node)
                    {
                        if (current.NextNode.NextNode == null)
                        {
                            current.NextNode = null;
                            break;
                        }
                        current.NextNode = current.NextNode.NextNode;
                        break;
                    }
                    current = current.NextNode;
                }
            }
            _numberOfNodes--;
        }

        public void DeleteValue(int val)
        {
            Node current = _headNode;
            while (current.NextNode != null)
            {
                if (current.Value == val)
                    break;
                current = current.NextNode;
            }
            DeleteNode(current);
        }

        public void Clear()
        {
            _headNode = null;
            _numberOfNodes = 0;
        }

        public bool Contain(int val)
        {
            Node current = _headNode;
            while (current.NextNode != null)
            {
                if (current.Value == val)
                    return true;
                current = current.NextNode;
            }
            return false;
        }

        public void RemoveDuplicates()
        {
            Node current = _headNode;
            Node compare = current.NextNode;
            while (current.NextNode != null)
            {
                while (compare != null)
                {
                    if (current.Value == compare.Value)
                    {
                        this.DeleteNode(compare);
                        break;
                    }
                    compare = compare.NextNode;
                }
                current = current.NextNode;
                compare = current.NextNode;
            }
        }

        public int NthNodeValueFromEnd(int n)
        {
            Node firstRef = _headNode;
            Node secondRef = _headNode;
            for (int i = 0; i < n - 1; i++)
            {
                firstRef = firstRef.NextNode;
            }
            while (firstRef.NextNode != null)
            {
                firstRef = firstRef.NextNode;
                secondRef = secondRef.NextNode;
            }
            return secondRef.Value;
        }

        public bool IsPalindrome()
        {
            Node current = _headNode;
            List<int> values = new List<int>();
            while (current != null)
            {
                values.Add(current.Value);
                current = current.NextNode;
            }
            for (int i = 0; i < _numberOfNodes / 2; i++)
            {
                if (values[i] != values[_numberOfNodes - i - 1])
                    return false;
            }
            return true;
        }

        public IEnumerator<Node> GetEnumerator()
        {
            Node current = _headNode;
            while (current != null)
            {
                yield return current;
                current = current.NextNode;
            }
        }
    }
}
