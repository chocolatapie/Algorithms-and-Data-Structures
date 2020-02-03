using System;
using System.Collections.Generic;

namespace Algoritms_and_DataStructures.StackAndQueue
{
    public class CustomQueue
    {
        private NodeSQ _headNode;
        private NodeSQ _tailNode;

        public int Count { get; private set; }

        public bool IsEmpty => Count == 0;

        public void Enqueue(int value)
        {
            NodeSQ node = new NodeSQ(value);
            NodeSQ tempNode = _tailNode;
            _tailNode = node;

            if (Count == 0)
                _headNode = _tailNode;
            else
                tempNode.NextNode = _tailNode;

            Count++;
        }

        public int Dequeue()
        {
            if (IsEmpty)
                throw new Exception("Queue is empty!");

            int retValue = _headNode.Value;
            _headNode = _headNode.NextNode;
            Count--;
            return retValue;
        }

        public int FirstValue()
        {
            if (IsEmpty)
                throw new Exception("Queue is empty!");
            return _headNode.Value;
        }

        public int LastValue()
        {
            if (IsEmpty)
                throw new Exception("Queue is empty!");
            return _tailNode.Value;
        }

        public bool Contains(int value)
        {
            if (IsEmpty)
                throw new Exception("Queue is empty!");
            NodeSQ current = _headNode;
            while (current != null)
            {
                if (current.Value == value)
                    return true;
                current = current.NextNode;
            }
            return false;
        }

        public IEnumerator<NodeSQ> GetEnumerator()
        {
            NodeSQ current = _headNode;
            while (current != null)
            {
                yield return current;
                current = current.NextNode;
            }
        }
    }
}