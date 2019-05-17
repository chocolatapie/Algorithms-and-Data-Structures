namespace Algoritms_and_DataStructures.BinaryTree
{
    public class BinaryTreeNode
    {
        public int Value { get; set; }

        public BinaryTreeNode LeftChild { get; set; }

        public BinaryTreeNode RightChild { get; set; }

        public BinaryTreeNode(int value)
        {
            Value = value;
        }
    }
}