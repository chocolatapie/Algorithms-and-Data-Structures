using System;
using System.Collections;
using System.Collections.Generic;

namespace Algoritms_and_DataStructures.BinaryTree
{
    class CustomBinaryTree
    {
        private int _nodesNumbers { get; set; }
        public BinaryTreeNode RootNode { get; private set; }
        
        public int Count
        {
            get { return _nodesNumbers; }
        }

        public bool IsEmpty
        {
            get { return _nodesNumbers == 0; }
        }

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
            {
                AddTo(RootNode, val);
            }
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
                {
                    AddTo(node.LeftChild, val);
                }
            }
            else
            {
                if (node.RightChild == null)
                {
                    node.RightChild = new BinaryTreeNode(val);
                    _nodesNumbers++;
                }
                else
                {
                    AddTo(node.RightChild, val);
                }
            }
        }

        public void InOrderTraversal(BinaryTreeNode root)
        {
            if (IsEmpty)
                throw new Exception("Tree is empty!");

            if (root.LeftChild != null)
            {
                InOrderTraversal(root.LeftChild);
            }
            Console.WriteLine(root.Value);
            if (root.RightChild != null)
            {
                InOrderTraversal(root.RightChild);
            }
        }

        public void PreOrderTraversal(BinaryTreeNode root)
        {
            if (IsEmpty)
                throw new Exception("Tree is empty!");

            Console.WriteLine(root.Value);
            if (root.LeftChild != null)
            {
                InOrderTraversal(root.LeftChild);
            }
            if (root.RightChild != null)
            {
                InOrderTraversal(root.RightChild);
            }
        }

        public bool Contains(int item)
        {
            BinaryTreeNode currentNode = RootNode;

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
            BinaryTreeNode currentNode = RootNode;
            BinaryTreeNode toRetrun = null;
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
                        toRetrun = currentNode;
                        break;
                }
            }
            return toRetrun;
        }

        public List<int> NodesToList(BinaryTreeNode root)
        {
            List<int> nodesVal = new List<int>();
            if (root.LeftChild != null)
            {
                InOrderTraversal(root.LeftChild);
            }
            nodesVal.Add(root.Value);
            if (root.RightChild != null)
            {
                InOrderTraversal(root.RightChild);
            }
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

        public void craeteLevelLinkedLists(BinaryTreeNode root, List<LinkedList<BinaryTreeNode>> lists, int level)
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
            craeteLevelLinkedLists(root.LeftChild, lists, level + 1);
            craeteLevelLinkedLists(root.RightChild, lists, level + 1);
        }

        public List<LinkedList<BinaryTreeNode>> craeteLevelLinkedLists(BinaryTreeNode root)
        {
            List<LinkedList<BinaryTreeNode>> lists = new List<LinkedList<BinaryTreeNode>>();
            craeteLevelLinkedLists(root, lists, 0);
            return lists;
        }

        private static int? lastPrinted;
        public bool IsBinarySearchTree(BinaryTreeNode root)
        {
            if (root == null)
                return true;
            if (!IsBinarySearchTree(root.LeftChild))
                return false;
            if (lastPrinted != null && root.Value <= lastPrinted)
                return false;

            lastPrinted = root.Value;
            if (!IsBinarySearchTree(root.RightChild))
                return false;

            return true;
        }
    }
}
