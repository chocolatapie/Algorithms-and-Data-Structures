using System;
using System.Collections.Generic;

namespace Algoritms_and_DataStructures.StackAndQueue
{
    class CustomStack
    {
        private int _nodeNumbers;
        private NodeSQ _headNode;

        public int Count
        {
            get { return _nodeNumbers; }
        }

        public int GetMinimum()
        {
            int min = _headNode.Value;
            NodeSQ current = _headNode;
            while (current != null)
            {
                if (current.Value < min)
                    min = current.Value;
                current = current.NextNode;
            }
            return min;
        }

        public bool IsEmpty
        {
            get { return _nodeNumbers == 0; }
        }

        public bool ContainsValue(int value)
        {
            NodeSQ current = _headNode;
            while (current != null)
            {
                if (current.Value == value)
                    return true;
                current = current.NextNode;
            }
            return false;
        }

        public void Push(int value)
        {
            NodeSQ node = new NodeSQ(value);
            node.NextNode = _headNode;
            _headNode = node;
            _nodeNumbers++;
        }

        public void BubbleMinUp()
        {
            NodeSQ current = _headNode;
            NodeSQ minNode = null;
            int minVal = this.GetMinimum();

            while (current != null)
            {
                if (minVal == current.Value)
                {
                    minNode = current;
                    break;
                }
                current = current.NextNode;
            }

            NodeSQ current2 = _headNode;
            while (current2.NextNode != null)
            {
                if (current2.NextNode == minNode)
                {
                    if (current2.NextNode.NextNode == null)
                    {
                        current2.NextNode = null;
                        break;
                    }
                    current2.NextNode = current2.NextNode.NextNode;
                }
                current2 = current2.NextNode;
            }
            minNode.NextNode = _headNode;
            _headNode = minNode;
        }

        public NodeSQ Pop()
        {
            if (IsEmpty)
            {
                throw new Exception("Empty Stack!");
            }
            NodeSQ retNode = _headNode;
            _headNode = _headNode.NextNode;
            _nodeNumbers--;
            return retNode;
        }

        public NodeSQ Peek()
        {
            if (IsEmpty)
            {
                throw new Exception("Empty Stack!");
            }
            return _headNode;
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
