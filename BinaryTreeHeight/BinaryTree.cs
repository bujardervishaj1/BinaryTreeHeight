namespace BinaryTreeHeight
{
    public class BinaryTree
    {
        public Node root;

        public int MaxDepth()
        {
            if (root == null)
                return 0;
            else
            {
                int lDepth = root.left.MaxDepth();
                int rDepth = root.right.MaxDepth();

                return lDepth > rDepth ? lDepth + 1 : rDepth + 1;
            }
        }
    }
}
