namespace BinaryTreeHeight
{
    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int item)
        {
            data = item;
            left = right = null;
        }

        public int MaxDepth()
        {
            if (this == null)
                return 0;
            else
            {
                int lDepth = this.left != null ? this.left.MaxDepth() : 0;
                int rDepth = this.right  != null ? this.right.MaxDepth() : 0;

                return lDepth > rDepth ? lDepth + 1 : rDepth + 1;
            }
        }
    }
}
