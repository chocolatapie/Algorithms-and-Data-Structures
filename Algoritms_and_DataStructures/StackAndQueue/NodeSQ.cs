namespace Algoritms_and_DataStructures.StackAndQueue
{
    public class NodeSQ
    {
        public int Value { get; set; }

        public NodeSQ NextNode { get; set; }

        public NodeSQ(int val)
        {
            Value = val;
        }
    }
}