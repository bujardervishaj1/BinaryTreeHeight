namespace BinaryTreeHeight
{
    public class BinaryTree
    {
        public Node root;

        public int MaxDepth(Node node)
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
