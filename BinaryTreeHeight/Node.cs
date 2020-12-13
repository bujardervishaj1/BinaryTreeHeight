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

        public static int MaxDepth(Node node)
        {
            if (node == null)
                return 0;
            else
            {
                int lDepth = MaxDepth(node.left);
                int rDepth = MaxDepth(node.right);

                return lDepth > rDepth ? lDepth + 1 : rDepth + 1;
            }
        }
    }
}
