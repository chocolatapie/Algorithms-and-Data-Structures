using System;
using System.Collections;
using System.Collections.Generic;

namespace Algoritms_and_DataStructures.BinaryTree
{
    class CustomBinaryTree
    {
        private int _nodesNumbers;
        private int? _lastPrinted;

        public BinaryTreeNode RootNode { get; private set; }

        public int Count => _nodesNumbers;

        public bool IsEmpty => _nodesNumbers == 0;

        public void Clear()
        {
            RootNode = null;
            _nodesNumbers = 0;
        }

        public void InsertNode(int val)
        {
            if (RootNode == null)
            {
                RootNode = new BinaryTreeNode(val);
                _nodesNumbers++;
            }
            else
                AddTo(RootNode, val);
        }

        public void AddTo(BinaryTreeNode node, int val)
        {
            if (node.Value > val)
            {
                if (node.LeftChild == null)
                {
                    node.LeftChild = new BinaryTreeNode(val);
                    _nodesNumbers++;
                }
                else
                    AddTo(node.LeftChild, val);
            }
            else
            {
                if (node.RightChild == null)
                {
                    node.RightChild = new BinaryTreeNode(val);
                    _nodesNumbers++;
                }
                else
                    AddTo(node.RightChild, val);
            }
        }

        public void InOrderTraversal(BinaryTreeNode root)
        {
            if (IsEmpty)
                throw new Exception("Tree is empty!");

            if (root.LeftChild != null)
                InOrderTraversal(root.LeftChild);

            Console.WriteLine(root.Value);

            if (root.RightChild != null)
                InOrderTraversal(root.RightChild);
        }

        public void PreOrderTraversal(BinaryTreeNode root)
        {
            if (IsEmpty)
                throw new Exception("Tree is empty!");

            Console.WriteLine(root.Value);

            if (root.LeftChild != null)
                InOrderTraversal(root.LeftChild);

            if (root.RightChild != null)
                InOrderTraversal(root.RightChild);
        }

        public bool Contains(int item)
        {
            var currentNode = RootNode;

            while (currentNode != null)
            {
                switch (item.CompareTo(currentNode.Value))
                {
                    case -1:
                        currentNode = currentNode.RightChild;
                        break;
                    case 1:
                        currentNode = currentNode.LeftChild;
                        break;
                    default: // case 0
                        return true;
                }
            }
            return false;
        }

        private BinaryTreeNode FindNode(int val)
        {
            var currentNode = RootNode;
            BinaryTreeNode returningNode = null;
            while (currentNode != null)
            {
                switch (val.CompareTo(currentNode.Value))
                {
                    case -1:
                        currentNode = currentNode.RightChild;
                        break;
                    case 1:
                        currentNode = currentNode.LeftChild;
                        break;
                    default: // case 0
                        returningNode = currentNode;
                        break;
                }
            }
            return returningNode;
        }

        public List<int> NodesToList(BinaryTreeNode root)
        {
            List<int> nodesVal = new List<int>();
            if (root.LeftChild != null)
                InOrderTraversal(root.LeftChild);

            nodesVal.Add(root.Value);
            if (root.RightChild != null)
                InOrderTraversal(root.RightChild);

            return nodesVal;
        }

        public IEnumerator GetEnumerator()
        {
            List<int> nodes = NodesToList(this.RootNode);
            foreach (var a in nodes)
            {
                yield return a;
            }
        }

        public void CreateLevelLinkedLists(BinaryTreeNode root, List<LinkedList<BinaryTreeNode>> lists, int level)
        {
            if (root == null)
                return;

            LinkedList<BinaryTreeNode> list = null;
            if (lists.Count == level)
            {
                list = new LinkedList<BinaryTreeNode>();
                lists.Add(list);
            }
            else
            {
                list = (LinkedList<BinaryTreeNode>)lists[level];
            }

            list.AddLast(root);
            CreateLevelLinkedLists(root.LeftChild, lists, level + 1);
            CreateLevelLinkedLists(root.RightChild, lists, level + 1);
        }

        public bool IsBinarySearchTree(BinaryTreeNode root)
        {
            if (root == null)
                return true;

            if (!IsBinarySearchTree(root.LeftChild))
                return false;

            if (_lastPrinted != null && root.Value <= _lastPrinted)
                return false;

            _lastPrinted = root.Value;
            if (!IsBinarySearchTree(root.RightChild))
                return false;

            return true;
        }
    }
}
